using System;
using System.Threading;

namespace DesignPatterns.CreationalPatterns.Singleton.Example3
{
    /// <summary>
    /// <see fref="https://en.wikipedia.org/wiki/Lazy_initialization"></see>
    /// <see fref="https://www.dntips.ir/post/1897/"></see>
    /// </summary>
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance =
            new Lazy<LazySingleton>(() => new LazySingleton(), LazyThreadSafetyMode.ExecutionAndPublication);

        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get { return _instance.Value; }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}