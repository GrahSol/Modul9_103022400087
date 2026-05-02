using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400087
{
    public class Transfer
    {
        public double threshold;
        public double low_fee;
        public double high_fee;

        public Transfer(double threshold, double low_fee, double high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;

        }
    }
}
