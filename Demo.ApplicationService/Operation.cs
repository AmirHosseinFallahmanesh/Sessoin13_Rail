using System;

namespace Demo.ApplicationService
{
    public class Operation
    {

        public int Sum(int number1,int number2)
        {
            return number1 + number2;
        }

        /// <summary>
        /// تقسیم را انجام دهد
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2">
        ///ا گر ورودی دوم صفر باشد صفر برگرداند
        /// </param>
        /// <returns></returns>
        public double Divide(int number1,int number2)
        {
            if (number2==0)
            {
                throw new DivideByZeroException();
            }
            return number1 / number2;
        }


    }
}
