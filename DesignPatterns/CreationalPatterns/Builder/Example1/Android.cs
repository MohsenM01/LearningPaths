namespace DesignPatterns.CreationalPatterns.Builder.Example1
{
    public class Android : IBuilder
    {
        public Product p;
        public Android()
        {
            p = new Product("Android Cell Phone");
        }
        public void BuildScreen()
        {
            p.Screen = "Touch Screen 16 Inch!";
        }

        public void BuildOS()
        {
            p.OS = "Android 4.4";
        }
        public Product Product
        {
            get { return p; }
        }
    }
}