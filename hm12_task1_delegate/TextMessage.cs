using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm12_task1_delegate
{
    internal class TextMessage
    {
        public void OutputGreeting(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        public void OutputTodayDate(string name)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine($"{name}, it is {today.ToString("dd.MM.yyyy")} {today.DayOfWeek} today");
        }
        public void OutputTodayTime(string name)
        {
            DateTime clock = DateTime.Now;

            Console.WriteLine($"{name}, it is {clock.ToString("HH:mm")} o'clock now");
        }
        public void OutputFarewell(string name)
        {
            Console.WriteLine($"Goodbye {name}!");
        }
    }
}
