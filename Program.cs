using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    static void newthread1()
    {
        var nig = new num();
        Console.WriteLine("Ответ: " + nig.GetD());
        Thread.Sleep(400);
    }

    static void newthread2()
    {
        var nig = new num();
        nig.SetD(nig.GetA() + nig.GetB());
        Thread.Sleep(400);
    }

    static void newthread3()
    {
        var nig = new num();
        nig.SetD(nig.GetA() - nig.GetB());
        Thread.Sleep(400);
    }
    static void newthread4()
    {
        var nig = new num();
        nig.SetD(nig.GetA() / nig.GetB());
        Thread.Sleep(400);
    }
    static void newthread5()
    {
        var nig = new num();
        nig.SetD(nig.GetA() * nig.GetB());
        Thread.Sleep(400);
    }

    public class num
    {
        private double a;

        internal double GetA()
        {
            return a;
        }

        internal void SetA(double value)
        {
            a = value;
        }

        private double b;

        public double GetB()
        {
            return b;
        }

        public void SetB(double value)
        {
            b = value;
        }

        private double d;

        public double GetD()
        {
            return d;
        }

        public void SetD(double value)
        {
            d = value;
        }
    }
    static void Main(string[] args)
    {
        var nig = new num();
        Console.WriteLine("Калькулятор MK1");
        Console.Write("Введите число А: ");
        nig.SetA(Convert.ToDouble(Console.ReadLine()));
        Console.Write("Введите число B: ");
        nig.SetB(Convert.ToDouble(Console.ReadLine()));
        Console.Write("Введите действие(1(+),2(-),3(/),4(*): ");
        int c = Convert.ToInt32(Console.ReadLine());

        Thread thread1 = new Thread(newthread1);    //поток для вывода
        Thread thread2 = new Thread(newthread2);    //поток для сложения
        Thread thread3 = new Thread(newthread3);    //поток для вычитания
        Thread thread4 = new Thread(newthread4);    //поток для деления
        Thread thread5 = new Thread(newthread5);    //поток для умножения

        if (c == 1)
        {
            thread2.Start();
        }
        else if (c == 2)
        {
            thread3.Start();
        }
        else if (c == 3)
        {
            thread4.Start();
        }
        else if (c == 4)
        {
            thread5.Start();
        }
        else
        {
            Console.WriteLine("непраильно введены данные");
        }
        thread1.Start();

        Console.ReadKey();
    }

}

