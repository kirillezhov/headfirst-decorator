using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        //public abstract string GetDescription();
    }

    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }
    }

    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return beverage.Cost() + .15;
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + .10;
        }
    }
}
