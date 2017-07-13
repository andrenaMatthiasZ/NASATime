using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASATime
{
    public class Timer
    {
        private int startingValue = 10;
        
        public string countDown()
        {
            string message = "";

            for (int count = startingValue; count > 0; count--)
            {
                message = message + count + ", ";
            }

            message = message + 0;

            return message;
        }

        public void setStartingValue(int value)
        {
            startingValue = value;
        }
    }
}
