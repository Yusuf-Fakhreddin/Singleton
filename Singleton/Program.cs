using System;

namespace Singleton
{

    class Singleton
    {
        // static flag for object creation
        private static bool Flag = false;
        // private constructor to disallow normal object creation
        private Singleton()
        {

        }
        public static Singleton CreateObj()
        {
            // if no object was created, create one
            if (Flag==false)
            {
                Singleton i = new Singleton();
                Flag = true;
                return i;
            }
            else
            {
                return null;
            }
        }
        public void Speak()
        {
            Console.WriteLine("Hello There from Singleton Design Pattern");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Singleton i = Singleton.CreateObj();
            i.Speak();
            // Throws an error
            Singleton i2 = Singleton.CreateObj();
            i2.Speak();

        }
    }
}
