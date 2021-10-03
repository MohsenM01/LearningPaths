namespace DesignPatterns.CreationalPatterns.Builder.Example1
{
    public class BlackBerry : IBuilder
    {
        public Product p;

        public BlackBerry()
        {
            p = new Product("BlackBerry");
        }
        public void BuildScreen()
        {
            p.Screen = "Touch Screen 8 Inch!";
        }

        public void BuildOS()
        {
            p.OS = "BlackBerry XXX";
        }
        public Product Product
        {
            get { return p; }
        }
    }
}