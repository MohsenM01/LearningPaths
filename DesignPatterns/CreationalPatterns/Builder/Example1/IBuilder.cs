
namespace DesignPatterns.CreationalPatterns.Builder.Example1
{
    public interface IBuilder
    {
        void BuildScreen();
        void BuildOS();
        Product Product { get; }
    }
}