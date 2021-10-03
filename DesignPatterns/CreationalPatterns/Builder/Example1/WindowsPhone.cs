namespace DesignPatterns.CreationalPatterns.Builder.Example1
{
    public class WindowsPhone : IBuilder
    {
        public Product p;

        public WindowsPhone()
        {
            p = new Product("Windows Phone");
        }
        public void BuildScreen()
        {
            p.Screen = "Touch Screen 32 Inch!";
        }

        public void BuildOS()
        {
            p.OS = "Windows Phone 2014";
        }
        public Product Product
        {
            get { return p; }
        }
    }
}