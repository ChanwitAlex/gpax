using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gpax
{
    internal class GPACalculator
    {
        private double gpa_sum = 0;
        private int n;
        private double gpa_min = double.MaxValue;
        private double gpa_max = double.MinValue;

        public void setGPA(double gpa)
        {
            this.gpa_sum += gpa;
            this.n++;

            if (gpa < gpa_min) gpa_min = double.MaxValue;
        }
        public double getMaxGPa()
        {
            return (n > 0) ? this.gpa_max: 0;
        }
        public double getMinGPA()
        {
            return (n > 0) ? this.gpa_min : 0;
        }
        public double getGPAX()
        {
            return (n > 0) ? this.gpa_sum / this.n : 0;
        }
    }
}
