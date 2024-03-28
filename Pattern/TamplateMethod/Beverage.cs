using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Core
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }

    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.Write("Would you like lemon with your tea (y/n)? ");
            string answer = Console.ReadLine();
            return answer.ToLower() == "y";
        }
    }

    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}