namespace DesignPatterns.CreationalPatterns.Singleton.Example2
{
    /// <summary>
    /// <see fref="https://www.dntips.ir/post/1911/"></see>
    /// </summary>
    public class SingletonClassCreator<T> where T : class, new()
    {
        private static T _singletoneInstance;
        private static readonly object Lock = new object();

        public static T SingletoneInstance
        {
            get
            {
                if (_singletoneInstance == null)
                {
                    lock (Lock)
                    {
                        if (_singletoneInstance == null)
                            _singletoneInstance = new T();
                    }
                }
                return _singletoneInstance;
            }
        }

        private SingletonClassCreator()
        {
        }
    }
}