using System;

namespace CS.Impl._04_Advanced
{
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                // The first call will create the one and only instance.
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                // Every call afterwards will return the single instance created above.
                return _instance;
            }
        }
    }

    public interface IMySingleton {
    }
    public class MySingleton : IMySingleton { }
}