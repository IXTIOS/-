using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Nuckleus_of_App
{
    public partial class MainForm : Form
    {
        #region delegates and events
        public delegate void FirstInjectionSpeedChangeEvent();

        public event FirstInjectionSpeedChangeEvent OnFirstInjectionSpeedChangeEvent;//for change inj speed after first minutes of injection

        public delegate void TheraputicalConcentrationLow();
        public event TheraputicalConcentrationLow OnTheraputicalConcentrationLow;

        #endregion


        #region input from form
        static double selectedVolume = 0.1678941;
        static double selectedClearance = 0.00108;
        static int timeStep = 1;//CONST
        static int firstInjectionTime = 5;
        static int seconadryInjectionsTime = 10;
        static bool makeInjectionsDurationEqual = false;
        static double primaryConcentration = 0;
        static double theraputicalConcentration = 4;
        static double toxicalConcentration = 40;
        static int loadDose = 500;
        static int supportDose = 500;
        static double bodyWeight = 70;
        static int computationTimeRange = 1000;
        static double[] dataArray;
        static int numberOfSecondaryInjections = 1;
        static double speedOfInjection = 0;
        static int totalNumberofSecondaryInjections = 0;
        static decimal drawingSpeed = 9;
        #endregion

        #region computed values
        static double totalVolume = 0;
        static double totalClearance = 0;
        static double speedOFFirstInjection = 0;
        static double speedOfSecondaryInjections = 0;
        static int counterForTimer = 0;
        static int currentRowInDataTable = 0;
        static DateTime pointsFOrXAxis = new DateTime();

        #endregion

        public MainForm()
        {
            InitializeComponent();
            //CheckIniFileExists(); uncomment later
            OnFirstInjectionSpeedChangeEvent += ChangeInjectSpeed;
            OnTheraputicalConcentrationLow += ChangeSpeedForSecondaryInjection;
        }

        private void AssignAndCompute()
        {
            totalVolume = bodyWeight * selectedVolume;
            totalClearance = bodyWeight * selectedClearance;
            speedOFFirstInjection = loadDose / firstInjectionTime;
            speedOfSecondaryInjections = supportDose / seconadryInjectionsTime;


            double CurrentConcentration = primaryConcentration;
            if (dataArray != null)
            {
                Array.Clear(dataArray, 0, dataArray.Count() - 1);
            }
            dataArray = new double[computationTimeRange];
            speedOfInjection = speedOFFirstInjection;
            int timerForSecondaryInjections = 0;
            totalNumberofSecondaryInjections = 0;


            //Расчет концентрации
            for (int i = 0; i < computationTimeRange; i += timeStep)
            {
                if (totalNumberofSecondaryInjections >= numberOfSecondaryInjections)
                {
                    speedOfInjection = 0;
                }
                else
                {
                    if (i == 0)
                    {
                        dataArray[i] = primaryConcentration;
                        CurrentConcentration = dataArray[i];
                        continue;
                    }
                    if (i == firstInjectionTime + 1)
                    {
                        OnFirstInjectionSpeedChangeEvent();
                    }
                    if (CurrentConcentration <= theraputicalConcentration && i > firstInjectionTime && totalNumberofSecondaryInjections <= numberOfSecondaryInjections)
                    {
                        OnTheraputicalConcentrationLow();
                        timerForSecondaryInjections++;
                    }
                    if (CurrentConcentration > theraputicalConcentration && speedOfInjection != 0 && timerForSecondaryInjections % seconadryInjectionsTime > 0 && i > firstInjectionTime)
                    {
                        dataArray[i] = (speedOfInjection - totalClearance * CurrentConcentration) * timeStep / totalVolume + CurrentConcentration;
                        CurrentConcentration = dataArray[i];
                        timerForSecondaryInjections++;
                        continue;
                    }
                    if (CurrentConcentration > theraputicalConcentration && speedOfInjection != 0 && timerForSecondaryInjections % seconadryInjectionsTime == 0 && i > firstInjectionTime)
                    {
                        speedOfInjection = 0;
                        timerForSecondaryInjections = 0;
                        totalNumberofSecondaryInjections++;
                    }
                }
                dataArray[i] = (speedOfInjection - totalClearance * CurrentConcentration) * timeStep / totalVolume + CurrentConcentration;
                CurrentConcentration = dataArray[i];
            }



        }

        public void ChangeSpeedForSecondaryInjection()
        {
            speedOfInjection = speedOfSecondaryInjections;
        }

        private void ChangeInjectSpeed()
        {
            speedOfInjection = 0;
        }


        private void ConcentrationChart_Click(object sender, EventArgs e)
        {
            pointsFOrXAxis = DateTime.Now;
            ConcentrationChart.ChartAreas.Clear();
            ConcentrationChart.Legends.Clear();
            ConcentrationChart.Series.Clear();
            ConcentrationChart.ChartAreas.Add("Concentration");
            ConcentrationChart.Titles.Add("Концентрация фортазима в плазме крови");

            #region concentration curve
            ConcentrationChart.ChartAreas["Concentration"].AxisX.Title = "Время";
            ConcentrationChart.ChartAreas["Concentration"].AxisY.Title = "Концентрация мг/л";
            ConcentrationChart.ChartAreas["Concentration"].AxisX.Interval = 30;
            ConcentrationChart.ChartAreas["Concentration"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            ConcentrationChart.ChartAreas["Concentration"].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            ConcentrationChart.ChartAreas["Concentration"].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            ConcentrationChart.ChartAreas["Concentration"].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            ConcentrationChart.ChartAreas["Concentration"].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            ConcentrationChart.Legends.Add("Графики");
            ConcentrationChart.Legends["Графики"].Title = "Графики";
            ConcentrationChart.Series.Add("ConcentrationCurve");
            ConcentrationChart.Series["ConcentrationCurve"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            ConcentrationChart.Series["ConcentrationCurve"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            ConcentrationChart.Series["ConcentrationCurve"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            ConcentrationChart.Series["ConcentrationCurve"].BorderWidth = 3;
            ConcentrationChart.Series["ConcentrationCurve"].IsVisibleInLegend = true;
            ConcentrationChart.Series["ConcentrationCurve"].LegendText = "Концентрация фортазима";
            #endregion

            #region toxic line

            ConcentrationChart.Series.Add("ToxicConcentration");
            ConcentrationChart.Series["ToxicConcentration"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            ConcentrationChart.Series["ToxicConcentration"].Color = Color.Red;
            ConcentrationChart.Series["ToxicConcentration"].BorderWidth = 3;
            ConcentrationChart.Series["ToxicConcentration"].IsVisibleInLegend = true;
            ConcentrationChart.Series["ToxicConcentration"].LegendText = "Токсическая концентрация";
            #endregion

            #region theraputic line
            ConcentrationChart.Series.Add("TheraputicConcentration");
            ConcentrationChart.Series["TheraputicConcentration"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            ConcentrationChart.Series["TheraputicConcentration"].Color = Color.Green;
            ConcentrationChart.Series["TheraputicConcentration"].BorderWidth = 3;
            ConcentrationChart.Series["TheraputicConcentration"].IsVisibleInLegend = true;
            ConcentrationChart.Series["TheraputicConcentration"].LegendText = "Терапевтическая концентрация";


            for (int i = 0; i < computationTimeRange; i += timeStep)
            {

                ConcentrationChart.Series["ConcentrationCurve"].Points.AddXY(pointsFOrXAxis.AddMinutes(i).ToOADate(), dataArray[i]);
                ConcentrationChart.Series["ToxicConcentration"].Points.AddXY(pointsFOrXAxis.AddMinutes(i).ToOADate(), toxicalConcentration);
                ConcentrationChart.Series["TheraputicConcentration"].Points.AddXY(pointsFOrXAxis.AddMinutes(i).ToOADate(), theraputicalConcentration);
            }

            graphTimer.Start();

        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            counterForTimer = 0;
            graphTimer.Tick += new EventHandler(GraphTimer_Tick);
            AssignAndCompute();
            CreateGraphics();
            graphTimer.Start();
            ComputeButton.Enabled = false;
            if (ConcentrationDataGrid != null)
            {
                ConcentrationDataGrid.Rows.Clear();
                ConcentrationDataGrid.Columns.Clear();
                ConcentrationDataGrid.Refresh();
            }
            ConcentrationDataGrid.Columns.Add("Date", "Дата");
            ConcentrationDataGrid.Columns.Add("Time", "Время");
            ConcentrationDataGrid.Columns.Add("Concentration", "Концентрация");
        }


        private void GraphTimer_Tick(object sender, EventArgs e)
        {
            {

                ConcentrationChart.Series["ConcentrationCurve"].Points.AddXY(pointsFOrXAxis.AddMinutes(counterForTimer).ToOADate(), dataArray[counterForTimer]);
                ConcentrationChart.Series["ToxicConcentration"].Points.AddXY(pointsFOrXAxis.AddMinutes(counterForTimer).ToOADate(), toxicalConcentration);
                ConcentrationChart.Series["TheraputicConcentration"].Points.AddXY(pointsFOrXAxis.AddMinutes(counterForTimer).ToOADate(), theraputicalConcentration);
                ConcentrationDataGrid.Rows.Add(1);
                ConcentrationDataGrid.Rows[currentRowInDataTable].Cells[0].Value = pointsFOrXAxis.AddMinutes(counterForTimer).ToShortDateString();
                ConcentrationDataGrid.Rows[currentRowInDataTable].Cells[1].Value = pointsFOrXAxis.AddMinutes(counterForTimer).ToShortTimeString();
                ConcentrationDataGrid.Rows[currentRowInDataTable].Cells[2].Value = dataArray[counterForTimer];
                currentRowInDataTable++;
                counterForTimer += timeStep;
                if (counterForTimer == dataArray.Count())
                {
                    graphTimer.Stop();
                    ComputeButton.Enabled = true;
                }
            }


         
        }

        
    }
}


#endregion