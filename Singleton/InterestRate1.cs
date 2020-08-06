using System;

namespace Singleton
{
    public class InterestRate1
    {
        public double CurrentInterestRate { get { return 3.75; } }

        private static volatile InterestRate1 instance;
        private static object sync = new Object();
        private InterestRate1() { }

        public static InterestRate1 Instance
        {
            get
            {
                if (null == instance)
                {
                    lock (sync)
                    {
                        if (null == instance)
                        {
                            instance = new InterestRate1();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
