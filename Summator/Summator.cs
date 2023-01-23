using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Summator
{
    public static class Summator
    {

        //Sum method
        public static double Sum(double[] arr)
        {
            double result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return result;

        }


        //Average method
        public static double Average(double[] arr)
        {
            double result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            result = result / arr.Length;

            return result;

        }


        //Multiply method
        public static double Multiply(double[] arr)
        {
            double result = 0;

            if (arr.Length > 0)
            {
                result = arr[0];
            }

            for (int i = 1; i < arr.Length; i++)
            {

                result *= arr[i];
            }

            return result;
        }
    }
}


