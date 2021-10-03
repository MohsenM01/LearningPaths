using System;

namespace DesignPatterns.CreationalPatterns.Singleton.Example1
{
    /// <summary>
    /// <see fref="https://www.tutorialspoint.com/design_pattern/singleton_pattern.htm"></see>
    /// <see fref="https://en.wikipedia.org/wiki/Lazy_initialization"></see>
    /// <see fref="https://www.dntips.ir/post/2015/"></see>
    /// </summary>
    public class SingletonClass
    {
        private static SingletonClass _singletoneInstance;
        private static readonly object Lock = new object();


        private SingletonClass()
        {
        }

        public static SingletonClass SingletoneInstance
        {
            get
            {
                if (_singletoneInstance == null)
                {
                    lock (Lock)
                    {
                        if (_singletoneInstance == null)
                            _singletoneInstance = new SingletonClass();
                    }
                }
                return _singletoneInstance;
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }

    }
}