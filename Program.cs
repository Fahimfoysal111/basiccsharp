using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExamc_
{
    internal class Program
    { 
        public static int groth = 10;//global scope variable
        static void Dosum(int num1 = 3, int num2 = 4)
        {
            int Result;
            Result = num1 + num2;
            Console.WriteLine("the Result is " + Result);
        }
        static void StudenDetails(string Name, string Subject = "C#")//here Subject is optional parameter
        {
            Console.WriteLine("Name={0} Subject={1}", Name, Subject);
        }
        static void Main(string[] args)
        {
            
            Dosum(5, 6); //calling method
            StudenDetails(Name: "Asif Hossain", Subject: "SQL");

            //Tuple
            var Tspinfo = ("CenterName=USSL", "TotalStudent=15", "Dhaka", 1212);
            Console.WriteLine(Tspinfo);
            
            
            
            Console.WriteLine("If   Else");
            int z = 10;
            if (z % 2 == 0)
            {
                Console.WriteLine("This condition is right");

            }
            else
            {
                Console.WriteLine("This condition is wrong");
            }
            Console.WriteLine("Switch Case ");
            int day = 2;
            switch (day)
            {
                case 0:
                    Console.WriteLine("Saturday");
                    break;
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                default:
                    Console.WriteLine("Day not Found");
                    break;
            }
            Console.WriteLine("This is While iteration Statment");
            int c = 2;
            while (c < 10)
            {
                Console.WriteLine(c);
                c++;
            }
            Console.WriteLine("This is for iteration statement");
            for (int v = 2; v < 10; v++)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("This is do iteration statement");
            int n = 2;
            do
            {
                Console.WriteLine(n);
                n++;
            }
            while (n < 10);
            
            Console.WriteLine("Using primitive data types");
            int age = 10;
            string Name = "Asif Hossain";
            double Salary = 15000.00;
            bool cutsalary = false;
            Console.WriteLine(Name);
            Console.WriteLine(age);
            Console.WriteLine(Salary);
            Console.WriteLine(cutsalary);
            Console.WriteLine("Arithmetic Operator");
            int s = 10;
            int d = 5;
            int result;
            result = s + d;
            Console.WriteLine("Addition =" + result);
                result = s - d;
            Console.WriteLine("Subtraction =" + result);
            result = s * d;
            Console.WriteLine("Multiplication =" + result);
            result = s / d;
            Console.WriteLine("Divition =" + result);

            Console.WriteLine("different between prefix and postfix");
            int j = 10;
            Console.WriteLine("value for j " + j);
            j++;
            Console.WriteLine("value for j " + j);
            ++j;
            Console.WriteLine("value for j " + j);
            j++;

            Console.WriteLine("Differenct between while and do");
            //while
            int k = 10;
            while (k < 20)
            {
                Console.WriteLine("This is while loof " + k);
                k++;
            }
            //do while
            int m = 2;
            do
            {
                Console.WriteLine("This is do loof " + m);
                m++;
            }
            while (m < 10);
            
            
            //uncheck
            int r = int.MaxValue;
            unchecked
            {
                Console.WriteLine(r + 3);
            }
            //check
            try
            {
                checked
                {
                    Console.WriteLine(r + 3);

                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("This is catch");
                Console.WriteLine(ex.Message);

            }
            
            
            int f = 0;
            int p = 0;
            try
            {
                p = 100 / f;
                Console.WriteLine("This is try");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("This is catch");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("At last we found result ");
                Console.WriteLine(p);
            }
            Console.ReadLine();




        }
    }
}
