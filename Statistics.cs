using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТП_Лаба_3
{
    public class Statistics
    {
        
        public void UpdateStatistics(List<Day> days, out float MaxSpeed_res, out float MaxTime_res, out float Distance_res)
        {
            
            //// Находим максимальную скорость
            float res = 0;
            for (int i = 0; i < days.Count; i++)
            {
                if (days[i].MaxSpeed > res)
                {
                    res = days[i].MaxSpeed;
                }
            }
           MaxSpeed_res = res;
            //// Находим максимальную длительность тренировки
            res = 0;
            for (int i = 0; i < days.Count; i++)
            {
                if (days[i].Duration > res)
                {
                    res = days[i].Duration;
                }
            }
            MaxTime_res = res;
            //// Находим колво км за выходные
            res = 0;
            for (int i = 0; i < days.Count; i++)
            {
                if (days[i].date.DayOfWeek == DayOfWeek.Sunday || days[i].date.DayOfWeek == DayOfWeek.Saturday)
                {
                    res += days[i].Distance;
                }
            }
            Distance_res = res;

        }


    }
}
