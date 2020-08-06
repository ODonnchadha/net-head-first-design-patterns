using System;

namespace Singleton
{
    public class InterestRate2
    {
        private InterestRate2() { }

        private static Lazy<InterestRate2> instance = new Lazy<InterestRate2>(() => new InterestRate2());

        public static InterestRate2 Instance
        {
            get { return instance.Value; }
        }

        public double CurrentInterestRate { get { return 3.75; } }
    }
}
