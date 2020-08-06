using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Singleton
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            double currentInterestRate;

            currentInterestRate = InterestRate1.Instance.CurrentInterestRate;
            currentInterestRate = InterestRate2.Instance.CurrentInterestRate;

            Console.WriteLine(currentInterestRate);
            Console.ReadLine();
        }
    }
}
