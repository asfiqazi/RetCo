using System.Collections.Generic;

namespace RetCoUI
{
    public class ComputationBase
    {
        public List<string> Register { get; set; } = new List<string>();

        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}