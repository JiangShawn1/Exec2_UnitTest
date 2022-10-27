using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwainStockUtility
{
    public class TaiwainStockUtility
    {
        public bool IsTradingTime(DateTime dt)
        {
            bool isTrading = dt.DayOfWeek != DayOfWeek.Sunday;

            dt = isTrading ? dt : new DateTime(1, 1, 1, 0, 0, 0);

            bool isTrading2 = dt.DayOfWeek != DayOfWeek.Saturday;

            dt = isTrading2 ? dt : new DateTime(1, 1, 1, 0, 0, 0);
            
                                    
            int minute = dt.Minute;
            int hour = dt.Hour;
            DateTime time=new DateTime(1,1,1,hour,minute,0);
            bool isTradingTime = dt.Hour >= 09 &&  time<=new DateTime(1,1,1,13,30,0) ;
            return isTradingTime;
        }
    }
}
