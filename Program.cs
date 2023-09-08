using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begin_доп_задания
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////begin 5
            //int a;
            //int S;
            //int V;
            //Console.WriteLine(" чему равно а ");
            //string e = Console.ReadLine();
            //a = int.Parse(e);
            //Console.WriteLine("P = " + Math.Pow(a,3));
            //Console.WriteLine("S = " + 6 * Math.Pow(a,2));



            ////begin 7
            //double L;
            //double R;
            //double S;
            //Console.WriteLine("какое значение R ");
            //string t = Console.ReadLine();
            //R = double.Parse(t);
            //L = 2 * Math.PI * R;
            //S = Math.PI * Math.Pow(R, 2);
            //Console.WriteLine("L = " + L);
            //Console.WriteLine("S = " + S);




            ////begin 9
            //double a;
            //double b;
            //double k;
            //Console.WriteLine(" значение числа а");
            //string e = Console.ReadLine();
            //a = double.Parse(e);
            //Console.WriteLine("значение числа b");
            //string f = Console.ReadLine();
            //b= double.Parse(f);
            //k = Math.Sqrt(a * b);
            //Console.WriteLine("k = " + k);





            ////begin 10
            //double a;
            //double b;
            //double s;
            //double r;
            //double p;
            //double k;
            //Console.WriteLine(" значение числа а");
            //string e = Console.ReadLine();
            //a = double.Parse(e);
            //Console.WriteLine("значение числа b");
            //string f = Console.ReadLine();
            //b = double.Parse(f);
            //s = Math.Sqrt(a + b);
            //r = Math.Sqrt(a - b);
            //p = Math.Sqrt(a * b);
            //k = Math.Sqrt(a / b);
            //Console.WriteLine("r = " + r);
            //Console.WriteLine("s = " + s);
            //Console.WriteLine("p = " + p);
            //Console.WriteLine("k = " + k);






            ////integer 2
            //int M;
            //int T;
            //Console.WriteLine("сколько масса в кг");
            //string w = Console.ReadLine();
            //M = int.Parse(w);
            //T = M / 1000;
            //Console.WriteLine("T = " + T);



            ////integer 4
            //int a;
            //int b;
            //Console.WriteLine(" значение числа а");
            //string e = Console.ReadLine();
            //a = int.Parse(e);
            //Console.WriteLine("значение числа b");
            //string f = Console.ReadLine();
            //b = int.Parse(f);
            //Console.WriteLine("в отрезке а содержится " + a / b + " полных отрезков b");




            ////integer 6
            //int a;
            //int s;
            //int d;
            //Console.WriteLine(" ввести 2-х значное число");
            //string t = Console.ReadLine();
            //a = int.Parse(t);
            //s = a / 10;
            //Console.WriteLine("s = " + s);
            //d = a % 10;
            //Console.WriteLine("d = " + d);





            ////inter 7
            //int a;
            //int s;
            //int d;
            //Console.WriteLine(" ввести 2-х значное число");
            //string t = Console.ReadLine();
            //a = int.Parse(t);
            //s = a / 10;
            //d = a % 10;
            //Console.WriteLine("сумма цифр числа = " + (d + s));
            //Console.WriteLine("разность цифр числа = " + d * s);




            ////if 2
            //double a;
            //Console.WriteLine("введите значинение числа а");
            //string q = Console.ReadLine();
            //a = double.Parse(q);
            //if (a > 0)
            //{
            //    Console.WriteLine("число является положительным : " + (a + 1));
            //}
            //else {
            //    Console.WriteLine("число является отрицательным : " + (a - 2));
            //}




            ////if 4
            //double a;
            //double b;
            //double c;
            //double N;
            //Console.WriteLine("введите значение числа а");
            //string z = Console.ReadLine();
            //a = double.Parse(z);
            //Console.WriteLine("введите значение числа b");
            //string v = Console.ReadLine();
            //b = double.Parse(v);
            //Console.WriteLine("введите значение числа а");
            //string w = Console.ReadLine();
            //c = double.Parse(w);
            //N = 0;
            //if (a > 0) ++ N;
            //if (b > 0) ++ N;
            //if (c > 0) ++ N;
            //Console.WriteLine("колличество положительных чисел: " + N);



            ////if 7
            //int a;
            //int b;
            //Console.WriteLine("введите значение числа а");
            //string z = Console.ReadLine();
            //a = int.Parse(z);
            //Console.WriteLine("введите значение числа b");
            //string v = Console.ReadLine();
            //b = int.Parse(v);
            //if (a < b)
            //{
            //    Console.WriteLine("меньшее из чисел: " + a);
            //}
            //else
            //{
            //    Console.WriteLine("меньшее из чисел: " + b);
            //}




            //if 9
            int a;
            int b;
            int c;
            Console.WriteLine("введите значение числа а");
            string n = Console.ReadLine();
            a = int.Parse(n);
            Console.WriteLine("введите значение числа b");
            string m = Console.ReadLine();
            b = int.Parse(m);
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("a: " + a + " b: " + b);

            }
            else
            {
                Console.WriteLine("a: " + a + " b: " + b);
            }

            //thygyugfjykujgvfjtkyghgjyhg

            Console.ReadKey();

        }
    }
}
