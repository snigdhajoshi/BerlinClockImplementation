using BerlinClock.Classes;
using System;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
       public string convertTime(string aTime)
        {
            string[] rows = aTime.Split(':');
            string[] convertedTime = new string[5];
            if (rows.Length < 3)
            {
                return ("Insufficient data to calculate time");
            }

            string[] hours = GetHours(rows[0]);
            if (hours == null)
            {
                return ("Invalid hours string");
            }
            else
            {
                convertedTime[1] = hours[0];
                convertedTime[2] = hours[1];
            }

            string[] minutes = GetMinutes(rows[1]);
            if (minutes == null)
            {
                return ("Invalid minutes string");
            }
            else
            {
                convertedTime[3] = minutes[0];
                convertedTime[4] = minutes[1];
            }

            convertedTime[0] = GetSeconds(rows[2]);

            return string.Join("\n", convertedTime);
            
        }

        private string GetSeconds(string value)
        {
            var seconds = Convert.ToInt16(value);
            if (seconds % 2 == 0)
            {
                return "Y";
            }
            else
            {
                return "O";
            }
        }

        private string[] GetHours(string value)
        {
            var hours = Convert.ToInt16(value);
            if (hours > 24)
            {
                return null;
            }
            else
            {
                return new string[] {
                    TimeConverterHelper.GetRowString(hours, isfirstRow: true, isHour: true ),
                    TimeConverterHelper.GetRowString(hours, isfirstRow: false, isHour: true) };
            }
        }
        private string[] GetMinutes(string value)
        {
            var minutes = Convert.ToInt16(value);
            if (minutes > 59)
            {
                return null;
            }
            else
            {
                return new string[] {
                    TimeConverterHelper.GetRowString(minutes, isfirstRow: true, isHour: false),
                    TimeConverterHelper.GetRowString(minutes, isfirstRow: false, isHour: false) };
            }
        }
        
    }
}
