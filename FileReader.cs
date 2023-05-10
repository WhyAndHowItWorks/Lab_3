using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТП_Лаба_3
{
    public class FileReader
    {
        
        public Form1 form;
        public string File;
        public StreamReader sr;
        public StreamWriter sw;
        public void ReadFile()
        {
            sr = new StreamReader(File);
            int count = Convert.ToInt16(sr.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Day temp = new Day();
                temp.date = DateTime.Parse(sr.ReadLine());
                temp.Duration = Convert.ToInt32(sr.ReadLine());
                temp.MaxSpeed = float.Parse(sr.ReadLine());
                temp.MinSpeed = float.Parse(sr.ReadLine());
                temp.AverageSpeed = float.Parse(sr.ReadLine());
                temp.AveragePulse = float.Parse(sr.ReadLine());
                temp.Distance = float.Parse(sr.ReadLine());
                form.Days.Add(temp);
                form.DaysSpisok.Items.Add(temp.date.ToString());
            }
            sr.Close();
        }
        public void WriteFile()
        {
            sw = new StreamWriter(File);
            sw.WriteLine(form.Days.Count);
            for (int i = 0; i < form.Days.Count; i++)
            {
                sw.WriteLine(form.Days[i].date.ToString());
                sw.WriteLine(form.Days[i].Duration.ToString());
                sw.WriteLine(form.Days[i].MaxSpeed.ToString());
                sw.WriteLine(form.Days[i].MinSpeed.ToString());
                sw.WriteLine(form.Days[i].AverageSpeed.ToString());
                sw.WriteLine(form.Days[i].AveragePulse.ToString());
                sw.WriteLine(form.Days[i].Distance.ToString());
            }
            sw.Close();
        }
        public FileReader(string File, Form1 form)
        {
            this.File = File;
            this.form = form;
        }
       
    }
}
