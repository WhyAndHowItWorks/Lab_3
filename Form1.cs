using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ТП_Лаба_3
{
    public partial class Form1 : Form
    {


        public List<Day> Days = new List<Day>();

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            InitializeComponent();
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
            
            DaysSpisok.Items.Add(temp.date.ToString());
        }
       
       
    }
}
