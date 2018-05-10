using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class TimeConversion
    {
        // from https://www.hackerrank.com/challenges/time-conversion/problem
        // Notes: 
        // Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock.
        // Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.
        // input: hh:mm:ss[AM|PM]

        static public string timeConversion(string s)
        {
            if (s == "12:00:00PM")
            {
                return "12:00:00";
            }
            if (s == "12:00:00AM")
            {
                return "00:00:00";
            }

            if (s.Contains("AM"))
            {
                // hh:mm:ssAM
                char[] separator = { ':' };
                string[] token = s.Split(separator);
                int hour = int.Parse(token[0]);
                if ( hour == 12 )
                {
                    hour = 0;
                }
                string firstDigit = "";
                if (hour < 10)
                {
                    firstDigit = "0";
                }
                string military = String.Concat(firstDigit, hour.ToString(), ":", token[1], ":", token[2][0], token[2][1]);
                return military;
            }
            else
            {
                // hh:mm:ssPM
                char[] separator = { ':' };
                string[] token = s.Split(separator);
                int hour = int.Parse(token[0]);
                if (hour < 12 )
                {
                    hour += 12;
                }
                string military = String.Concat(hour.ToString(), ":", token[1], ":", token[2][0], token[2][1]);
                return military;
            }

        }
    }
}