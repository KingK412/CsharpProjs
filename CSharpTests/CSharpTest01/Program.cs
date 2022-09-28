using System;

namespace CSharpTest01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            DerivedA c1 = new DerivedA(); 
        }
    }


    class Base<T>
    {

    }

    class DerivedA : Base<string>
    {

    }

    class DerivedB<T, U> : Base<T>
    {

    }
}
