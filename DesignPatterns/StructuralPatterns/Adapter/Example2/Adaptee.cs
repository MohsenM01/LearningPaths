using System;

namespace DesignPatterns.StructuralPatterns.Adapter.Example2
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("SpecificRequest() is called");
        }
    }
}
