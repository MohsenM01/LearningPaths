using System;

namespace DesignPatterns.StructuralPatterns.Adapter.Example1
{
    public class Adaptee
    {
        public void SpecificationRequest()
        {
            Console.WriteLine("SpecificationRequest() is called");
        }
    }
}
