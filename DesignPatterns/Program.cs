using System;
using DesignPatterns.CreationalPatterns.Singleton.Example1;
using DesignPatterns.CreationalPatterns.Singleton.Example2;
using DesignPatterns.CreationalPatterns.Singleton.Example3;
using DesignPatterns.CreationalPatterns.Builder.Example1;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {


            SingletonClass.SingletoneInstance.ShowMessage();

            var firstSingletone = SingletonClassCreator<FirstSingleton>.SingletoneInstance;
            Console.WriteLine(firstSingletone.Square(12));

            LazySingleton.Instance.ShowMessage();

            Director d = new Director();
            Android cb1 = new Android();
            d.Construct(cb1);
            Console.WriteLine(cb1.p.ToString());


            DesignPatterns.StructuralPatterns.Adapter.Example1.ITarget target1 = new DesignPatterns.StructuralPatterns.Adapter.Example1.Adapter();
            target1.Request();

            DesignPatterns.StructuralPatterns.Adapter.Example2.ITarget target2 = new DesignPatterns.StructuralPatterns.Adapter.Example2.Adapter();
            target2.Request();

        }
    }
}
