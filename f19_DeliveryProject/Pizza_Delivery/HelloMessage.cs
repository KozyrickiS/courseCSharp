using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public class HelloMessage
    {
        delegate void Message();
        public void ByTime()
        {
            Message message;
            TimeSpan time = DateTime.Now.TimeOfDay;
            if (time.Hours > 5 && time.Hours < 12)
            {
                message = GoodMorning;
            }
            else if (time.Hours >= 12 && time.Hours <= 19)
            {
                message = GoodDay;
            }
            else
            {
                message = GoodEvening;
            }
            message();
        }
        private static void GoodMorning()
        {
            Console.Write("Good Morning, Sunshine! ");
        }
        private static void GoodDay()
        {
            Console.Write("Good Day, Honey! ");
        }
        private static void GoodEvening()
        {
            Console.Write("Good Evening, Sugar! ");
        }

    }
}
