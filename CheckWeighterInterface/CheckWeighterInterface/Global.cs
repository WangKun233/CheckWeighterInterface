﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckWeighterInterface
{
    class Global
    {
        /******************************************************系统设置*********************************************************************/
        public static MySQL.MySQLHelper mysqlHelper1 = new MySQL.MySQLHelper("localhost", "check_weighter_data_analysis", "root", "ei41");



        //public delegate void BrandChangedReinit(object sender, EventArgs e);
        //public static event BrandChangedReinit brandChangedReInitStatusMonitor;
        //public static event BrandChangedReinit brandChangedReInitTimeDomainAnalysis;
        //public static event BrandChangedReinit brandChangedReInitFrequencyDomainAnalysis;
        //public static event BrandChangedReinit brandChangedReInitExcelExport;
        //public static event BrandChangedReinit brandChangedReInitSystemConfig;

        /******************************************************全局参数********************************************************************/

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
        public static Status curStatus = new Status();     //当前状态
         
        public static double underWeightThreshold;         //欠重阈值（设定值为初始值）
        public static double overWeightThreshold;          //超重阈值（设定值为初始值）



        /******************************************************全局方法************************************************************************/
        
        //初始化数据库
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

        //DataTable序号重排
        public static void reorderDt(ref DataTable dt, string colNOName)
        {
            int lenDt = dt.Rows.Count;
            for (int i = 0; i < lenDt; i++)
            {
                dt.Rows[i][colNOName] = (i + 1).ToString();
            }
        }

        //显示informationBox
        public static void showInforMationBox(XtraUserControl xx, CommonControl.InformationBox informationBox, string title, int locX, int locY)
        {
            if (informationBox != null)
                informationBox.Dispose();

            informationBox = new CommonControl.InformationBox();
            informationBox.Appearance.BackColor = System.Drawing.Color.White;
            informationBox.Appearance.Options.UseBackColor = true;
            informationBox.Name = "confirmationBox_invalidTime";
            informationBox.Size = new System.Drawing.Size(350, 150);
            informationBox.Location = new Point(locX, locY);
            informationBox.TabIndex = 29;
            informationBox.infoTitle = title;
            xx.Controls.Add(informationBox);
            informationBox.Visible = true;
            informationBox.BringToFront();
        }

        /******************************************************各个页面***************************************************************************/

        //StatusMonitor
        public static bool enableRefreshStatusMonitor = true;                              //StatusMonitor页面刷新使能标志
        public static DataTable dtBrand = new DataTable("tableBrand");                     //品牌表
        public static DataTable dtLineStatusMonitor = new DataTable("tableLine");          //折线图数据源，只显示200个点
        public static DataTable dtPieStatusMonitor = new DataTable("tablePie");            //饼图数据源，只要不更换brand就一直累计
        public static DataTable dtPointStatusMonitor = new DataTable("tablePoint");        //散点图数据源，只要不更换brand就一直累计

        //RealTimeCurve
        public static bool enableReFreshRealTimeCurve = true;                                   //RealTimeCurve页面刷新使能标志
        public static DataTable dtSensorRealTimeData = new DataTable("dtSensorRealTimeData");   //传感器实时数据dt
        public static double sensorRealTimeDataPeak;                                            //传感器实时数据峰值
        public static double sensorRealTimeDataValley;                                          //传感器实时数据谷值
        public static double sensorRealTimeDataAvg;                                             //传感器实时数据平均值

        //CalibrationCorrection
        //public static double[] calibrationDataGradient;    //标定数据列表：各段斜率，用于根据传感器值计算重量。标定即计算斜率。
        public static DataTable dtCalibrationGradient = new DataTable("dtCalibrationGradient");



    }
}
