using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class helper_CalcoliHelper
    {

        public static int sumNumber(int num1, int num2)
        {
           int sum = num1 + num2;
            return sum;
        }

        public static double sumNumberDouble(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }
        public static int divisionNumber(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        public static double divisionNumberDouble(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        public static int absoluteValue(int num)
        {
            if(num >= 0) 
            {
                return num;
            }else
            {
                return num * -1;
            }
        }

        public static double absoluteValue(double num)
        {
            if (num >= 0)
            {
                return num;
            }
            else
            {
                return num * -1;
            }
        }

        public static int minValue(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;  
            }
            else if(num2 < num1)
            {
                return num2;
            }
            else
            {
               return num1;
            }
        }

        public static double minValue(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else if (num2 < num1)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        public static int maxValue(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else if (num2 > num1)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        public static double maxValue(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else if (num2 > num1)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }



    }
}

