namespace DesignPatterns.StructuralPatterns.Adapter.Example2
{
    /// <summary>
    /// <see href="https://www.dntips.ir/post/1567"></see>
    /// </summary>
    public class Adapter : ITarget
    {
        private Adaptee _adptee = new Adaptee();

        public void Request()
        {
            _adptee.SpecificRequest();
        }
    }
}