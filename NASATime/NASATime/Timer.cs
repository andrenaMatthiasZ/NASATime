

using NASATime.Util;

namespace NASATime
{
    public class Timer
    {
        private int startingValue = 10;
        
        public string CountDown()
        {
            string message = "";

            for (int count = startingValue; count > 0; count--)
            {
                message = message.CombineWithComma(count.ToString());
            }
            message = message.CombineWithComma(0.ToString());

            return message;
        }

        public void setStartingValue(int value)
        {
            startingValue = value;
        }
    }
}
