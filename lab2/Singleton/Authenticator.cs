using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Singleton
{
    sealed class Authenticator
    {
        private static Authenticator? _instance;
        private static object _refObj = new object();

        private Authenticator()
        {
            Console.WriteLine("Initializing Authenticator");
        }

        public static Authenticator GetInstance()
        {
            if (Authenticator._instance == null)
            {
                lock (Authenticator._refObj)
                {
                    if (Authenticator._instance == null)
                    {
                        Authenticator._instance = new Authenticator();
                    }
                }
            }
            return Authenticator._instance;
        }
    }
}
