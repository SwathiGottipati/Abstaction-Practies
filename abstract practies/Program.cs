using System;

namespace Application
{
    abstract class Coffee
    {
        public abstract void Hotchocolate();
        public void Taste()
        {
            Console.WriteLine("hotchocolate is sweet");
        }

    }
    class Costa : Coffee
    {
        public override void Hotchocolate()
        {
            Console.WriteLine("costa is brand");
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Costa Brand = new Costa();
            Brand.Taste();
            Brand.Hotchocolate();
        }


    }
}

