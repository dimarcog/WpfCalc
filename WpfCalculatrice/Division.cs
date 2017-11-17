using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatrice
{
    class Division
    {
        private double val1;
        private double val2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="val1">First value</param>
        /// <param name="val2">Second value</param>
        public Division(double val1, double val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }

        /// <summary>
        /// Add the two setted values
        /// </summary>
        /// <returns>Result of sum</returns>
        public double Diviser()
        {
            return val1 / val2;
        }

        /// <summary>
        /// Get the first value
        /// </summary>
        /// <returns>Value</returns>
        public double getval1()
        {
            return this.val1;
        }

        /// <summary>
        /// Set the first value
        /// </summary>
        /// <param name="val">Value</param>
        public void setVal1(double val)
        {
            this.val1 = val;
        }

        /// <summary>
        /// Get the Second value
        /// </summary>
        /// <returns>Value</returns>
        public double getval2()
        {
            return this.val2;
        }

        /// <summary>
        /// Set the second value
        /// </summary>
        /// <param name="val">Value</param>
        public void setVal2(double val)
        {
            this.val2 = val;
        }

        public string Affiche()
        {
            return "The value of the division " + val1.ToString()
                   + " and " + val2.ToString()
                   + " is " + Diviser().ToString();
        }

    }
}
