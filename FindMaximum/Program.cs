using System;

namespace FindMaximum
{
    public class Program : IComparable
    {
        /// <summary>
        /// method to find maximum of three integer numbers
        /// </summary>
        /// <param name="num1"> number 1 </param>
        /// <param name="num2"> number 2 </param>
        /// <param name="num3"> number 3 </param>
        /// <returns> maximum number </returns>
        public int IntegerMaximum(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0)
            {
                return (num1.CompareTo(num3) > 0) ? num1 : num3;
            }
            else
            {
                return (num2.CompareTo(num3) > 0) ? num2 : num3;
            }
        }

        /// <summary>
        /// method to find maximum of three integer numbers
        /// </summary>
        /// <param name="num1"> number 1 </param>
        /// <param name="num2"> number 2 </param>
        /// <param name="num3"> number 3 </param>
        /// <returns> maximum number </returns>
        public float FloatMaximum(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0)
            {
                return (num1.CompareTo(num3) > 0) ? num1 : num3;
            }
            else
            {
                return (num2.CompareTo(num3) > 0) ? num2 : num3;
            }
        }

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// compare to interface implementation
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}