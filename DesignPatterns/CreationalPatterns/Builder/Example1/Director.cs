namespace DesignPatterns.CreationalPatterns.Builder.Example1
{
    /// <summary>
    /// <see href="https://www.dntips.ir/post/2015"></see>
    /// </summary>
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildScreen();
            builder.BuildOS();
        }
    }
}