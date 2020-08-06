using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Decorator
{
    class UpperCaseTextReader
    {
        TextReader myTextReader;

        UpperCaseTextReader(TextReader newTextReader)
        {
            this.myTextReader = newTextReader;
        }

        public string ReadToEnd()
        {
            return (myTextReader.ReadToEnd().ToUpper());

            // example
            //UpperCaseTextReader reader =
            //    new UpperCaseTextReader(new TextReader(
            //        new FileStream(path)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage bev = new AfricanBlend();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new HouseBlend();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new Cream(bev);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new Cream(bev);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            // We'll decorate an interface rather than an abstract base class
            IPizza pizza = new LargePizza();
            Console.WriteLine(
            String.Format("{0} - ${1}",
                pizza.GetDescription(),
                pizza.CalculateCost()));

            IPizza cheese = new Cheese(pizza);
            Console.WriteLine(
            String.Format("{0} - ${1}",
                cheese.GetDescription(),
                cheese.CalculateCost()));

            IPizza extra = new Cheese(cheese);
            Console.WriteLine(
            String.Format("{0} - ${1}",
                extra.GetDescription(),
                extra.CalculateCost()));

            IPizza sausage = new Sausage(extra);
            Console.WriteLine(
            String.Format("{0} - ${1}",
                sausage.GetDescription(),
                sausage.CalculateCost()));

            Console.ReadLine();
        }
    }
}
