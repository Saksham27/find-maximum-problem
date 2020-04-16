using System;

namespace FindMaximum
{
    public class MaxValue
    {
        /// <summary>
        /// method to find maximum of three integer numbers
        /// </summary>
        /// <param name="value1"> number 1 </param>
        /// <param name="value2"> number 2 </param>
        /// <param name="value3"> number 3 </param>
        /// <returns> maximum number </returns>
        public int IntegerMaximum(int value1, int value2, int value3)
        {
            if (value1.CompareTo(value2) > 0)
                return (value1.CompareTo(value3) > 0) ? value1 : value3;
            else
                return (value2.CompareTo(value3) > 0) ? value2 : value3;
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
                return (num1.CompareTo(num3) > 0) ? num1 : num3;
            else
                return (num2.CompareTo(num3) > 0) ? num2 : num3;
        }

        /// <summary>
        /// method to find maximum of three integer numbers
        /// </summary>
        /// <param name="num1"> number 1 </param>
        /// <param name="num2"> number 2 </param>
        /// <param name="num3"> number 3 </param>
        /// <returns> maximum number </returns>
        public string StringMaximum(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) > 0)
                return (str1.CompareTo(str3) > 0) ? str1 : str3;
            else
                return (str2.CompareTo(str3) > 0) ? str2 : str3;
        }

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

        }
    }

    public class FindMaximum<GenericType> where GenericType : IComparable
    {

        GenericType value1,
                    value2,
                    value3;


        /// <summary>
        /// method to find maximum of three Generic type numbers
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <returns> maximum </returns>
        public GenericType TestMaximum(GenericType value1, GenericType value2, GenericType value3)
        {
            if (value1.CompareTo(value2) > 0)
                return (value1.CompareTo(value3) > 0) ? value1 : value3;
            else
                return (value2.CompareTo(value3) > 0) ? value2 : value3;
        }
  
    }
}