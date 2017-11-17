using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatrice
{

    /// <summary>
    /// Simple multiplication class
    /// </summary>
    public class Multiplication
    {
        private double V1;
        private double V2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="val1">First value</param>
        /// <param name="val2">Second value</param>
        public Multiplication(double V1, double V2)
        {
            this.V1 = V1;
            this.V2 = V2;
        }
        /// <summary>
        /// Add the two setted values
        /// </summary>
        /// <returns>Result of Produit</returns>
        public double Multiplit()
        {
            return V1 * V2;
        }

        /// <summary>
        /// Get the first value
        /// </summary>
        /// <returns>Value</returns>
        public double getV1()
        {
            return this.V1;
        }

        /// <summary>
        /// Set the first value
        /// </summary>
        /// <param name="val">Value</param>
        public void setV1(double val)
        {
            this.V1 = val;
        }

        /// <summary>
        /// Get the Second value
        /// </summary>
        /// <returns>Value</returns>
        public double getV2()
        {
            return this.V2;
        }

        /// <summary>
        /// Set the second value
        /// </summary>
        /// <param name="val">Value</param>
        public void setV2(double val)
        {
            this.V2 = val;
        }

        public string Affiche()
        {
            return "The produit of " + V1.ToString()
                   + " and " + V2.ToString()
                   + " is " + Multiplit().ToString();
        }
    }
}
