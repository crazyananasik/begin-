using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begin_доп_задания
{
    internal class Program
    {
        static void qwe4()
        {
            int a;
            Console.WriteLine("введите число:");
            string w = Console.ReadLine();
            a = int.Parse(w);
            long f = 1;
            for(int i = 1; i <= a; i++)
            {
                f *= i;
            }
            Console.WriteLine($"факториал числа {a} равен {f}");

        }



        static void qwe3()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }



        static void for7()
        {
            double a;
            double b;
            double S = 0;
            Console.WriteLine("введите значение а");
            string w = Console.ReadLine();
            a = double.Parse(w);
            Console.WriteLine("введите значение в");
            string e = Console.ReadLine();
            b = double.Parse(e);
            for (double i = a; i <= b; i++)
            {
                S += i;
                Console.WriteLine($"сумма числел от {a} до {i} = {S}");
            }
        }



        static void for6()
        {
            double a;
            Console.WriteLine("введите цену за кг");
            string w = Console.ReadLine();
            a = double.Parse(w);
            for (double i = 1.2; i <= 2; i += 0.2)
            {
                double c = a * i;
                Console.WriteLine($"{i} кг конфт стоят {c} рублей");
            }
        }


        static void for5()
        {
            double a;
            Console.WriteLine("введите цену за кг :");
            string e = Console.ReadLine();
            a = double.Parse(e);
            for (double i = 0.1; i <= 1; i += 0.1)
            {
                double c = a * i;
                Console.WriteLine($"{i} кг конфет стоят {c} рублей");
            }
        }





        static void qwe2()
        {
            int a;
            int b;
            int n;
            int s;
            int f;
            Console.WriteLine("введите число");
            string q = Console.ReadLine();
            a = int.Parse(q);
            b = a % 10;
            n = a % 100 / 10;
            s = a / 100;
            f = b * 100 + n * 10 + s;
            if (a == f)
            {
                Console.WriteLine(f + " является полиндромом для числа " + a);
            }
            else
            {
                Console.WriteLine(f + " не является полиндромом для числа " + a);
            }
        }


        static void rubles()
        {

            int number;
            Console.WriteLine("введите число :");
            string t = Console.ReadLine();
            number = int.Parse(t);
            int dozens = number / 10 % 10;
            int unit = number % 10;
            if ((unit == 1) && (dozens != 1))
            {
                Console.WriteLine(number + " рубль");
            }
            else if ((unit >= 2 && unit <= 4) && (dozens != 1))
            {
                Console.WriteLine(number + " рубля");
            }
            else
            {
                Console.WriteLine(number + " рублей");
            }
        }

             


       


        static void begin7()
        {


            double L;
            double R;
            double S;
            Console.WriteLine("какое значение R ");
            string t = Console.ReadLine();
            R = double.Parse(t);
            L = 2 * Math.PI * R;
            S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("L = " + L);
            Console.WriteLine("S = " + S);
        }

        static void if14()
        {
            int a;
            int b;
            int c;
            Console.WriteLine(" значение числа а");
            string e = Console.ReadLine();
            a = int.Parse(e);
            Console.WriteLine("значение числа b");
            string f = Console.ReadLine();
            b = int.Parse(f);
            Console.WriteLine("значение числа c");
            string t = Console.ReadLine();
            c = int.Parse(t);
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine($"наименьшее {c}");
                }
                else
                {
                    Console.WriteLine($"наименьшее {b}");
                }
                Console.WriteLine($"наименьшее {a}");
            }
            else if (b > c && b > a)
            {
                if (a > c)
                {
                    Console.WriteLine($"наименьшее {c}");
                }
                else
                {

                }
            }
        }

        static void if13()
        {
            Console.WriteLine("if11");
            int a;
            int b;
            int c;
            Console.WriteLine(" значение числа а");
            string e = Console.ReadLine();
            a = int.Parse(e);
            Console.WriteLine("значение числа b");
            string f = Console.ReadLine();
            b = int.Parse(f);
            Console.WriteLine("значение числа c");
            string t = Console.ReadLine();
            c = int.Parse(t);
            if (a > b && a < c)
            {
                Console.WriteLine("a среднее");
            }
            else if (b < a && b > c)
            {
                Console.WriteLine("b среднее");
            }
            else if (c < a && c > b)
            {
                Console.WriteLine("c среднее");
            }
            else
            {
                Console.WriteLine("числа равны");
            }




        }
        static void Main(string[] args)
        {
            //if13();
            rubles();
            //qwe2 ();
            //for5();
            //for6();
            //for7();
            //qwe3();
            //qwe4();


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





            ////if 9
            //int a;
            //int b;
            //int c;
            //Console.WriteLine("введите значение числа а");
            //string n = Console.ReadLine();
            //a = int.Parse(n);
            //Console.WriteLine("введите значение числа b");
            //string m = Console.ReadLine();
            //b = int.Parse(m);
            //if (a > b)
            //{
            //    c = a;
            //    a = b;
            //    b = c;
            //    Console.WriteLine("a: " + a + " b: " + b);

            //}
            //else
            //{
            //    Console.WriteLine("a: " + a + " b: " + b);
            //}



            ////if 10
            //double a;
            //double b;
            //Console.WriteLine("Введите число A: ");
            //string tmp = Console.ReadLine();
            //a = double.Parse(tmp);
            //Console.WriteLine("Введите число B: ");
            //string tmk = Console.ReadLine();
            //b = double.Parse(tmk);
            //if (a == b)
            //{
            //    a = 0;
            //    b = 0;
            //    Console.WriteLine($"Результат: A = {a}, B = {b}");            
            //}
            //if (a!=b)
            //{
            //    double c = a + b;
            //    a = c;
            //    b = c;
            //    Console.WriteLine($"Результат: A = {a}, B = {b}");
            //}
            Console.ReadKey();
        
            





        }
    }
}
