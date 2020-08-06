using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return this.description;
        }

        public abstract double GetCost();
    }

    public class AfricanBlend : Beverage
    {
        public AfricanBlend()
        {
            this.description = "AfricanBlend";
        }

        public override double GetCost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend";
        }

        public override double GetCost()
        {
            return 0.89;
        }
    }

    public abstract class CondimentDecorator : Beverage
    {
    }

    public class Cream : CondimentDecorator
    {
        Beverage beverage;

        public Cream(Beverage newBeverage)
        {
            this.beverage = newBeverage;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", Cream " +
                this.GetCost();
        }

        public override double GetCost()
        {
            return 0.20 + this.beverage.GetCost();
        }
    }

    public interface IPizza
    {
        string Description { get; set; }
        string GetDescription();
        double CalculateCost();
    }

    public class LargePizza : IPizza
    {
        public string Description { get; set; }

        public double CalculateCost()
        {
            return 10.00;
        }

        public string GetDescription()
        {
            return this.GetType().Name;
        }
    }

    public class SmallPizza : IPizza
    {
        public string Description { get; set; }

        public double CalculateCost()
        {
            return 7.00;
        }

        public string GetDescription()
        {
            return this.GetType().Name;
        }
    }

    public abstract class PizzaDecorator : IPizza
    {
        protected readonly IPizza pizza;
        public string Description { get; set; }
        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public virtual double CalculateCost()
        {
            return this.pizza.CalculateCost();
        }

        public virtual string GetDescription()
        {
            return this.pizza.GetDescription();
        }
    }

    public class Cheese : PizzaDecorator
    {
        public Cheese(IPizza pizza) : base(pizza)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 3.00;
        }

        public override string GetDescription()
        {
            return string.Concat(base.GetDescription(), " and cheese");
        }
    }

    public class Sausage : PizzaDecorator
    {
        public Sausage(IPizza pizza) : base(pizza)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 10.00;
        }

        public override string GetDescription()
        {
            return string.Concat(base.GetDescription(), " and sausage");
        }
    }
}
