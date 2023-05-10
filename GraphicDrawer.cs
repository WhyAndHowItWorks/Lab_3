using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace ТП_Лаба_3
{
    public class GraphicDrawer
    {
        public Chart chart;

        public class DataSort:IComparable<DataSort>
       {
           public  double X;
           public  double Y;
            public DataSort(double X, double Y)
            {
                this.X = X;
                this.Y = Y;
            }
            public int CompareTo(DataSort dt)
            {
                if (dt.X > X)
                {
                    return -1;
                }
                else if (dt.X < X)
                {
                    return 1;
                }
                else 
                {
                    return 0;
                }
            }
        }
        public void DrawGraphic(string type1, string type2, double[] data1, double[] data2)
        {

            chart.Series.Clear();
            chart.Series.Add(new Series("Данные"));
            chart.Series[0].ChartType = SeriesChartType.FastLine;

            List<DataSort> data = new List<DataSort>();
            
            for (int i = 0; i < data1.Length; i++)
            {
                data.Add(new DataSort(data1[i], data2[i]));
            }
            data.Sort();
            for (int i = 0; i < data.Count; i++)
            {
                chart.Series[0].Points.AddXY(data[i].X, data[i].Y);
            }
            // additional styling
            chart.ResetAutoValues();
            chart.Titles.Clear();
            chart.ChartAreas[0].AxisX.Title = type1;
            chart.ChartAreas[0].AxisY.Title = type2;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
        }
        public GraphicDrawer(Chart chart)
        {
            this.chart = chart;
        }
       
    }
}
