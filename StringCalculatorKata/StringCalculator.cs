using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string v)
        {
            if (v == "")
            {
                //var x = "5,2".Split(",");
                //x = ["5", "2"];

                return 0;
            }
            return int.Parse(v);
           
        }

    }
}
