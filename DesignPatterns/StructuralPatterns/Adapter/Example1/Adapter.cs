namespace DesignPatterns.StructuralPatterns.Adapter.Example1
{
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            SpecificationRequest();
        }
    }
}