﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckWeighterInterface
{
    class Global
    {
        public static MySQL.MySQLHelper mysqlHelper1 = new MySQL.MySQLHelper("localhost", "check_weighter_data_analysis", "root", "ei41");

        //public delegate void BrandChangedReinit(object sender, EventArgs e);
        //public static event BrandChangedReinit brandChangedReInitStatusMonitor;
        //public static event BrandChangedReinit brandChangedReInitTimeDomainAnalysis;
        //public static event BrandChangedReinit brandChangedReInitFrequencyDomainAnalysis;
        //public static event BrandChangedReinit brandChangedReInitExcelExport;
        //public static event BrandChangedReinit brandChangedReInitSystemConfig;

        //状态参数
        public struct Status{
           public string brand;                         //品牌
           public double curWeight;                     //当前重量
           public string flagOverWeightOrUnderWeight;   //超重、欠重标志字符串
           public double lastOverWeight;                //上次超重
           public double lastUnderWeight;               //上次欠重
           public Int32 countDetection;                 //检测数量
           public Int32 countOverWeight;                //超重数量
           public Int32 countUnderWeight;               //欠重数量
           public double maxWeightInHistory;            //最大值
           public double minWeightInHistory;            //最小值
        };
        public static Status curStatus = new Status();      //当前状态
         
        public static double underWeightThreshold;         //欠重阈值（设定值为初始值）
        public static double overWeightThreshold;          //超重阈值（设定值为初始值）



        public static void initMySQL()
        {
            if (!mysqlHelper1._connectMySQL())
            {
                MessageBox.Show("数据库连接失败");
            }
        }

        //将当前状态写入MySQL
        public static void insertCurStatusMySQL()
        {
            string cmdInsertStatus = "INSERT INTO weight_history (Brand, Weight, Status, DateTime) VALUES ("
                                     + "'" + curStatus.brand + "'" + ", " + curStatus.curWeight.ToString() + ", " + "'" + curStatus.flagOverWeightOrUnderWeight + "'" + ", CURRENT_TIMESTAMP());";
            bool flag = mysqlHelper1._insertMySQL(cmdInsertStatus);
        }

        //查询
        public static void queryStatusHistoryMySQL(string st, string et, ref DataTable dt)
        {
            string cmdQueryLineHistoryMySQL = "CALL queryLineHistoryMySQL('" + st + "', '" + et + "');";
            Global.mysqlHelper1._queryTableMySQL(cmdQueryLineHistoryMySQL, ref dt);
        }

        public static void reorderDt(ref DataTable dt, string colNOName)
        {
            int lenDt = dt.Rows.Count;
            for (int i = 0; i < lenDt; i++)
            {
                dt.Rows[i][colNOName] = (i + 1).ToString();
            }
        }


        /******************************************************滤波函数****************************************************/
        public class FilteringFunc
        {
            //滤波算法
            /**如果本次值与上次值之差<=A,则本次值有效。如果本次值与上次值之差>A,则本次值无效,放弃本次值,用上次值代替本次值*/
            public int amplitudeLimitingFiltering(int valPre, int valCur, int threshold)
            {
                if ((valCur - valPre) > threshold || (valPre - valCur) > threshold)
                {
                    return valPre;
                }
                else
                {
                    return valCur;
                }
            }

            //中位值滤波
            /**连续采样N次（N取奇数），把N次采样值按大小排列 ，取中间值为本次有效值*/
            public int medianFiltering(int N, int[] valArr)
            {
                if (valArr.Length != N)
                    throw new ArgumentException();
                if (N % 2 == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.quickSort(valArr, 0, N - 1);
                    return valArr[N >> 1];
                }
            }

            private void quickSort(int[] s, int l, int r)
            {
                if (l < r)
                {
                    int i = l, j = r, x = s[l];
                    while (i < j)
                    {
                        while (i < j && s[j] >= x) // 从右向左找第一个小于x的数
                            j--;
                        if (i < j)
                            s[i++] = s[j];
                        while (i < j && s[i] < x) // 从左向右找第一个大于等于x的数
                            i++;
                        if (i < j)
                            s[j--] = s[i];
                    }
                    s[i] = x;
                    this.quickSort(s, l, i - 1); // 递归调用
                    this.quickSort(s, i + 1, r);
                }
            }

            //算术平均滤波
            /**连续取N个采样值进行算术平均运算。N值的选取：一般流量，N=12；压力：N=4*/
            public int digitalAverageFiltering(int N, int[] valArr)
            {
                if (valArr.Length != N)
                    throw new ArgumentException();
                int sum = 0;
                foreach (var val in valArr)
                {
                    sum += val;
                }
                return sum / N;
            }

            //递推平均滤波（滑动平均滤波）
            /**把连续取N个采样值看成一个队列，队列的长度固定为N每次采样到一个新数据放入队尾,并扔掉原来队首的一次数据.(先进先出原则)把队列中的N个数据进行算术平均运算,就可获得新的滤波结果N值的选取：流量，N=12；压力：N=4；液面，N=4~12；温度，N=1~4*/
            private Queue<int> sampleValueQueueRAF;
            public int recursionAverageFiltering(int N, int valCur)
            {
                int sum = 0;
                if (this.sampleValueQueueRAF.Count < N)
                {
                    this.sampleValueQueueRAF.Enqueue(valCur);

                    foreach (var v in this.sampleValueQueueRAF)
                    {
                        sum += v;
                    }
                    return sum / this.sampleValueQueueRAF.Count;
                }
                else
                {
                    this.sampleValueQueueRAF.Dequeue();
                    this.sampleValueQueueRAF.Enqueue(valCur);

                    foreach (var v in this.sampleValueQueueRAF)
                    {
                        sum += v;
                    }
                    return sum / N;
                }
            }

            //中位值平均滤波
            /**连续采样N个数据，去掉一个最大值和一个最小值然后计算N-2个数据的算术平均值N值的选取：3~14*/
            public int medianAverageFiltering(int N, int[] valArr)
            {
                if (valArr.Length != N)
                    throw new ArgumentException();

                int sum = 0;
                int minIndex = 0;
                int maxIndex = N - 1;
                for (int i = 0; i < N; i++)
                {
                    sum += valArr[i];
                    if (valArr[i] < valArr[minIndex])
                    {
                        minIndex = i;
                    }
                    else if (valArr[i] > valArr[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
                sum -= valArr[minIndex];
                sum -= valArr[maxIndex];
                return sum / N;
            }

            //限幅平均滤波
            /**相当于“限幅滤波法”+“递推平均滤波法”，每次采样到的新数据先进行限幅处理，再送入队列进行递推平均滤波处理*/
            public int amplitudeLimitingRecursionAverageFiltering(int N, int valPre, int valCur, int threshold)
            {
                int valTemp = this.amplitudeLimitingFiltering(valPre, valCur, threshold);
                return this.recursionAverageFiltering(N, valTemp);
            }


            //一阶滞后滤波
            /**取a=0~1本次滤波结果=（1-a)*本次采样值+a*上次滤波结果*/
            public int firstOrderLagFiltering(int valPre, int valCur, int a)
            {
                if (a < 0 || a > 100)
                    throw new ArgumentException();
                return (100 - a) * valPre + a * valCur;
            }


            //加权递推平均滤波法
            /**是对递推平均滤波法的改进，即不同时刻的数据加以不同的权通常是，越接近现时刻的数据，权取得越大。给予新采样值的权系数越大，则灵敏度越高，但信号平滑度越低*/
            //weightedArr-权重数组，升序。
            private Queue<int> sampleValueQueueWRAF;
            public int weightedRecursionAverageFiltering(int N, int valCur, int[] weightedArr)
            {
                if (weightedArr.Length != N)
                    throw new ArgumentException();

                int sumWeighted = 0;
                foreach (var v in weightedArr)
                {
                    sumWeighted += v;
                }

                int sum = 0;
                if (this.sampleValueQueueWRAF.Count < N)
                {
                    this.sampleValueQueueWRAF.Enqueue(valCur);
                }
                else
                {
                    this.sampleValueQueueWRAF.Dequeue();
                    this.sampleValueQueueWRAF.Enqueue(valCur);
                }

                for (int i = 0; i < this.sampleValueQueueWRAF.Count; i++)
                {
                    sum += this.sampleValueQueueWRAF.ElementAt(i) * weightedArr[i];
                }
                return sum / sumWeighted;
            }

            //消抖滤波法
            /**如果采样值＝当前有效值，则计数器清零如果采样值<>当前有效值，则计数器+1，并判断计数器是否>=上限N(溢出)如果计数器溢出,则将本次值替换当前有效值,并清计数器*/
            public bool flagEffectiveDitheringUsed = false;
            public int effectiveValDithering = 0;
            public int countDithering = 0;
            public int ditheringFiltering(int N, int valCur)
            {
                //若第一次调用该函数，将第一个采样值valCur作为有效值
                if (this.flagEffectiveDitheringUsed == false)
                {
                    this.effectiveValDithering = valCur;
                    this.flagEffectiveDitheringUsed = true;
                }

                if (valCur == this.effectiveValDithering)
                {
                    countDithering = 0;
                }
                else
                {
                    countDithering++;
                    if (countDithering >= N)
                    {
                        countDithering = 0;
                        this.effectiveValDithering = valCur;
                    }
                }
                return this.effectiveValDithering;
            }

            //限幅消抖滤波法
            public int amplitudeLimitingDitheringFiltering(int N, int valPre, int valCur, int threshold)
            {
                int valTemp = this.amplitudeLimitingFiltering(valPre, valCur, threshold);
                return this.ditheringFiltering(N, valTemp);
            }
        }


        ////滤波算法
        ///**如果本次值与上次值之差<=A,则本次值有效。如果本次值与上次值之差>A,则本次值无效,放弃本次值,用上次值代替本次值*/
        //public static int amplitudeLimitingFiltering(int valPre, int valCur, int threshold)
        //{
        //    if ((valCur - valPre) > threshold || (valPre - valCur) > threshold)
        //    {
        //        return valPre;
        //    }
        //    else
        //    {
        //        return valCur;
        //    }
        //}

        ////中位值滤波
        ///**连续采样N次（N取奇数），把N次采样值按大小排列 ，取中间值为本次有效值*/
        //public static int medianFiltering(int N, int[] valArr)
        //{
        //    if (valArr.Length != N)
        //        throw new ArgumentException();
        //    if (N % 2 == 0)
        //    {
        //        throw new ArgumentException();
        //    }
        //    else
        //    {
        //        quickSort(valArr, 0, N - 1);
        //        return valArr[N >> 1];
        //    }
        //}

        //private static void quickSort(int[] s, int l, int r)
        //{
        //    if (l < r)
        //    {
        //        int i = l, j = r, x = s[l];
        //        while (i < j)
        //        {
        //            while (i < j && s[j] >= x) // 从右向左找第一个小于x的数
        //                j--;
        //            if (i < j)
        //                s[i++] = s[j];
        //            while (i < j && s[i] < x) // 从左向右找第一个大于等于x的数
        //                i++;
        //            if (i < j)
        //                s[j--] = s[i];
        //        }
        //        s[i] = x;
        //        quickSort(s, l, i - 1); // 递归调用
        //        quickSort(s, i + 1, r);
        //    }
        //}

        ////算术平均滤波
        ///**连续取N个采样值进行算术平均运算。N值的选取：一般流量，N=12；压力：N=4*/
        //public static int digitalAverageFiltering(int N, int[] valArr)
        //{
        //    if (valArr.Length != N)
        //        throw new ArgumentException();
        //    int sum = 0;
        //    foreach (var val in valArr)
        //    {
        //        sum += val;
        //    }
        //    return sum / N;
        //}

        ////递推平均滤波（滑动平均滤波）
        ///**把连续取N个采样值看成一个队列，队列的长度固定为N每次采样到一个新数据放入队尾,并扔掉原来队首的一次数据.(先进先出原则)把队列中的N个数据进行算术平均运算,就可获得新的滤波结果N值的选取：流量，N=12；压力：N=4；液面，N=4~12；温度，N=1~4*/
        //private static Queue<int> sampleValueQueueRAF;
        //public static int recursionAverageFiltering(int N, int valCur)
        //{
        //    int sum = 0;
        //    if (sampleValueQueueRAF.Count < N)
        //    {
        //        sampleValueQueueRAF.Enqueue(valCur);

        //        foreach (var v in sampleValueQueueRAF)
        //        {
        //            sum += v;
        //        }
        //        return sum / sampleValueQueueRAF.Count;
        //    }
        //    else
        //    {
        //        sampleValueQueueRAF.Dequeue();
        //        sampleValueQueueRAF.Enqueue(valCur);

        //        foreach (var v in sampleValueQueueRAF)
        //        {
        //            sum += v;
        //        }
        //        return sum / N;
        //    }
        //}

        ////中位值平均滤波
        ///**连续采样N个数据，去掉一个最大值和一个最小值然后计算N-2个数据的算术平均值N值的选取：3~14*/
        //public static int medianAverageFiltering(int N, int[] valArr)
        //{
        //    if (valArr.Length != N)
        //        throw new ArgumentException();

        //    int sum = 0;
        //    int minIndex = 0;
        //    int maxIndex = N - 1;
        //    for (int i = 0; i < N; i++)
        //    {
        //        sum += valArr[i];
        //        if (valArr[i] < valArr[minIndex])
        //        {
        //            minIndex = i;
        //        }
        //        else if (valArr[i] > valArr[maxIndex])
        //        {
        //            maxIndex = i;
        //        }
        //    }
        //    sum -= valArr[minIndex];
        //    sum -= valArr[maxIndex];
        //    return sum / N;
        //}

        ////限幅平均滤波
        ///**相当于“限幅滤波法”+“递推平均滤波法”，每次采样到的新数据先进行限幅处理，再送入队列进行递推平均滤波处理*/
        //public static int amplitudeLimitingRecursionAverageFiltering(int N, int valPre, int valCur, int threshold)
        //{
        //    int valTemp = amplitudeLimitingFiltering(valPre, valCur, threshold);
        //    sampleValueQueueRAF.Clear();
        //    return recursionAverageFiltering(N, valTemp);
        //}


        ////一阶滞后滤波
        ///**取a=0~1本次滤波结果=（1-a)*本次采样值+a*上次滤波结果*/
        //public static int firstOrderLagFiltering(int valPre, int valCur, int a)
        //{
        //    if (a < 0 || a > 100)
        //        throw new ArgumentException();
        //    return (100 - a) * valPre + a * valCur;
        //}


        ////加权递推平均滤波法
        ///**是对递推平均滤波法的改进，即不同时刻的数据加以不同的权通常是，越接近现时刻的数据，权取得越大。给予新采样值的权系数越大，则灵敏度越高，但信号平滑度越低*/
        ////weightedArr-权重数组，升序。
        //private static Queue<int> sampleValueQueueWRAF;
        //public static int weightedRecursionAverageFiltering(int N, int valCur, int[] weightedArr)
        //{
        //    if(weightedArr.Length != N)
        //        throw new ArgumentException();

        //    int sumWeighted = 0;
        //    foreach(var v in weightedArr)
        //    {
        //        sumWeighted += v;
        //    }

        //    int sum = 0;
        //    if (sampleValueQueueWRAF.Count < N)
        //    {
        //        sampleValueQueueWRAF.Enqueue(valCur);
        //    }
        //    else
        //    {
        //        sampleValueQueueWRAF.Dequeue();
        //        sampleValueQueueWRAF.Enqueue(valCur);
        //    }

        //    for (int i = 0; i < sampleValueQueueWRAF.Count; i++)
        //    {
        //        sum += sampleValueQueueWRAF.ElementAt(i) * weightedArr[i];
        //    }
        //    return sum / sumWeighted;
        //}

        ////消抖滤波法
        ///**如果采样值＝当前有效值，则计数器清零如果采样值<>当前有效值，则计数器+1，并判断计数器是否>=上限N(溢出)如果计数器溢出,则将本次值替换当前有效值,并清计数器*/
        //public static bool flagEffectiveDitheringUsed = false;
        //public static int effectiveValDithering = 0;
        //public static int countDithering = 0;
        //public static int ditheringFiltering(int N, int valCur)
        //{
        //    //若第一次调用该函数，将第一个采样值valCur作为有效值
        //    if (flagEffectiveDitheringUsed == false)
        //    {
        //        effectiveValDithering = valCur;
        //        flagEffectiveDitheringUsed = true;
        //    }

        //    if(valCur== effectiveValDithering)
        //    {
        //        countDithering = 0;
        //    }
        //    else
        //    {
        //        countDithering++;
        //        if (countDithering >= N)
        //        {
        //            countDithering = 0;
        //            effectiveValDithering = valCur;
        //        }
        //    }
        //    return effectiveValDithering;
        //}

        ////限幅消抖滤波法
        //public static int amplitudeLimitingDitheringFiltering(int N, int valPre, int valCur, int threshold)
        //{
        //    int valTemp = amplitudeLimitingFiltering(valPre, valCur, threshold);
        //    flagEffectiveDitheringUsed = false;
        //    effectiveValDithering = 0;
        //    countDithering = 0;
        //    return ditheringFiltering(N, valTemp);
        //}



    }
}
