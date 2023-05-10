using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ТП_Лаба_3
{
    public partial class Form1 : Form
    {
        public List<Day> Days = new List<Day>();
        const string path = @"C:\Users\User\Desktop\ФайлДляЛабы.txt";
        public FileReader fr;
        public GraphicDrawer gd;
        public Statistics st;
        public string[] parametres = new string[7] { "День года","Max Speed","Min Speed","Avarage speed"
            ,"Duration(min)","Average pulse","Distance"};
        private void Form1_Load(object sender, EventArgs e)
        {
            gd = new GraphicDrawer(chart1);
            fr = new FileReader(path, this);
            st = new Statistics();
            fr.ReadFile();
            UpdateStatistics();

        }
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < parametres.Length; i++)
            {
                ChooseType1.Items.Add(parametres[i]);
                ChooseType2.Items.Add(parametres[i]);
            }

        }
        private void DaysSpisok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DaysSpisok.SelectedIndex != -1)
            {
                Day temp = Days[DaysSpisok.SelectedIndex];
                ChooseDate.Value = temp.date;
                MaxSpeed_Input.Text = temp.MaxSpeed.ToString();
                MinSpeed_Input.Text = temp.MinSpeed.ToString();
                Duration_Input.Text = temp.Duration.ToString();
                AvarageSpeed_Input.Text = temp.AverageSpeed.ToString();
                AvaragePulse_Input.Text = temp.AveragePulse.ToString();
                Distance_Input.Text = temp.Distance.ToString();
            }
        }

        private void AddDay_Click(object sender, EventArgs e)
        {
            Day temp = new Day();
            temp.date = ChooseDate.Value;
            temp.MaxSpeed = float.Parse(MaxSpeed_Input.Text);
            temp.MinSpeed = float.Parse(MinSpeed_Input.Text);
            temp.Duration = Convert.ToInt32(Duration_Input.Text);
            temp.AverageSpeed = float.Parse(AvarageSpeed_Input.Text);
            temp.AveragePulse = float.Parse(AvaragePulse_Input.Text);
            temp.Distance = float.Parse(Distance_Input.Text);
            Days.Add(temp);
            UpdateStatistics();
            DaysSpisok.Items.Add(temp.date.ToString());
        }
        private void SaveFile_Button_Click(object sender, EventArgs e)
        {
            fr.WriteFile();
        }

        double[] ChooseData(int parameter, out string type)
        {
            List<double> result = new List<double>();
            type = "0";
            switch (parameter)
            {
                case 0:
                    for (int i = 0; i < Days.Count; i++)
                    {
                        result.Add(Days[i].date.DayOfYear);
                        type = parametres[parameter];
                    }
                    break;
                case 1:
                    for (int i = 0; i < Days.Count; i++)
                    {
                        result.Add(Days[i].MaxSpeed);
                        type = parametres[parameter];
                    }
                    break;
                case 2:
                    for (int i = 0; i < Days.Count; i++)
                    {
                        result.Add(Days[i].MinSpeed);
                        type = parametres[parameter];
                    }
                    break;
                case 3:
                    for (int i = 0; i < Days.Count; i++)
                    {
                        result.Add(Days[i].Duration);
                        type = parametres[parameter];
                    }
                    break;
                case 4:
                    for (int i = 0; i < Days.Count; i++)
                    {
                        result.Add(Days[i].AverageSpeed);
                        type = parametres[parameter];
                    }
                    break;
                case 5:
                    for (int i = 0; i < Days.Count; i++)
                    {
                        result.Add(Days[i].AveragePulse);
                        type = parametres[parameter];
                    }
                    break;
                case 6:
                    for (int i = 0; i < Days.Count; i++)
                    {
                        result.Add(Days[i].Distance);
                        type = parametres[parameter];
                    }
                    break;
            }
            return result.ToArray();
        }
        public void UpdateStatistics()
        {
            float MaxSpeed;
            float MaxTime;
            float Distance;
            st.UpdateStatistics(Days, out MaxSpeed, out MaxTime, out Distance);
            MaxSpeed_st.Text = MaxSpeed.ToString();
            MaxDuration_st.Text = MaxTime.ToString();
            Distance_st.Text = Distance.ToString();
        }

        private void DrawGraphic_Click_1(object sender, EventArgs e)
        {
            string type1;
            double[] data1 = ChooseData(ChooseType1.SelectedIndex, out type1);
            string type2;
            double[] data2 = ChooseData(ChooseType2.SelectedIndex, out type2);
            gd.DrawGraphic(type1, type2, data1, data2);
        }
    }
}