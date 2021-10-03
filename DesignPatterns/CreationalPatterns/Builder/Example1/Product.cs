namespace DesignPatterns.CreationalPatterns.Builder.Example1
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Screen { get; set; }
        public string OS { get; set; }
        public override string ToString()
        {
            return string.Format(Screen + "/" + OS + "/" + Name);
        }
    }
}