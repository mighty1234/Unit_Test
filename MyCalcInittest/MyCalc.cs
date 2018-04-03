
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcInittest
{

    /// <summary>
    /// </summary>
    /// <remarks>
    /// Created by Vladislav Romenskiy 
    /// the remarks tag.</remarks>
    public class MyCalc
    {

        /// <summary>
        /// Сложение двух чисел 
        /// </summary>
        ///<param name="X">слагаемое А</param>
        ///<seealso cref="System.Double">
        ///<param name="y">слагаемое B</param>
        ///<seealso cref="System.Double">
        /// <returns><seealso cref="System.Double"></returns>
        public double Sum(double x,double y)
        {
            return x + y;
        }

        
        /// <summary>
        /// Вычетание  двух чисел 
        /// </summary>
        ///<param name="X">операнд А</param>
        ///<seealso cref="System.Double">
        ///<param name="y">операнд B</param>
        ///<seealso cref="System.Double">
        /// <returns><seealso cref="System.Double"></returns>
        public double Subtraction(double x, double y)
        {
            return x - y;
        }


        /// <summary>
        /// Умножение двух чисел 
        /// </summary>
        ///<param name="X">операнд А</param>
        ///<seealso cref="System.Double">
        ///<param name="y">операнд B</param>
        ///<seealso cref="System.Double">
        /// <returns><seealso cref="System.Double"></returns>
        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Деление  двух чисел 
        /// </summary>
        ///<param name="X">операнд А</param>
        ///<seealso cref="System.Double">
        ///<param name="y">операнд B</param>
        ///<seealso cref="System.Double">
        /// <returns><seealso cref="System.Double"></returns>
        public double Divide(double x, double y)
        {
            return x / y;
        }

        /// <summary>
        /// извлечение корня
        /// </summary>
        ///<param name="X">операнд </param>    
        ///<seealso cref="System.Double">    
        /// <returns><seealso cref="System.Double"></returns>
        public double SQRT(double x)
        {
            return Math.Sqrt(x);
        }

        /// <summary>
        /// Выражение со скобками
        /// </summary>
        ///<param name="X">операнд </param>    
        ///<seealso cref="System.String">    
        /// <returns><seealso cref="System.Double"></returns>

        //public double ROW(string  x)
        //{
        //    int bracketcounter = 0;
        //    int k = 0;
        //    char[] ch = x.ToCharArray();
        //    char[] items = { ')', '(' };
        //    int count = 0;
        //    string[] substring=null;
        //    char[] itemsubstring;

        //    for (int i = 0; i < ch.Length; i++)
        //    {
        //        if (x[i] == items[1])
        //        {
        //            count = count + 1;
        //        }
        //        if (x[i] == items[0])
        //        {
        //            count = count - 1;
        //        }


        //    }
        //    int containerCounter = 0;
        //    for (int i=k ; i < ch.Length; i++)
        //    {
        //        if (ch[i] != '(' || ch[i] != ')')
        //        {
        //            do
        //            {
        //                substring[containerCounter] += ch[i];
        //                i++;
        //            }
        //            while (ch[i + 1] == ')' || ch[i + 1] == '(');
        //            containerCounter += 1;
        //        }
              
        //        if (ch[i] =='(')
        //        {
        //            bracketcounter =+1;
        //            for (i=k; i < ch.Length; i++)
        //            {

        //                substring[containerCounter] += ch[i];


        //                i++;
        //                if (ch[i] == ')') ;
        //                break;
        //            }
                  
        //            containerCounter += 1;
        //        }

        //    }
        //    for (int l = 0; l < containerCounter; l++)
        //    {
        //        Console.WriteLine(substring[l]);
        //    }

        //        if (count!= 0)
        //        Console.WriteLine("выражение не верно ");


        //    return 2.2365;
        //}


      

    }

  
}
