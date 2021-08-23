using System;

namespace Decorator
{
    public interface ISandwich
    {
        void SandwichComposition();
    }

    public class Sandwich : ISandwich
    {
        public void SandwichComposition()
        {
            Console.WriteLine("Just ham and bread");
        }
    }

    public class SandwichDecorator : ISandwich
    {
        public ISandwich Sandwich;

        public SandwichDecorator(ISandwich sandwich)
        {
            Sandwich = sandwich;
        }
        public virtual void SandwichComposition()
        {
            Sandwich.SandwichComposition();
        }
    }

    public class AddIngredients : SandwichDecorator
    {
        public AddIngredients(ISandwich sandwich) : base(sandwich)
        {

        }

        public override void SandwichComposition()
        {
            Console.WriteLine("Bread, ham, cheese, lettuce and tomatoes.");
        }

    }

    public class AddEgg : SandwichDecorator
    {
        public AddEgg(ISandwich sandwich) : base(sandwich)
        {

        }

        public override void SandwichComposition()
        {
            Console.WriteLine("Bread, ham, cheese, with a fried egg, lettuce and tomatoes.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ISandwich sandwich = new Sandwich();
            sandwich.SandwichComposition();

            ISandwich moreIngredients = new AddIngredients(sandwich);
            moreIngredients.SandwichComposition();

            ISandwich addedEgg = new AddEgg(moreIngredients);
            addedEgg.SandwichComposition();

            // In teorie, in clasele decorator AddIngredients si AddEgg s-ar adauga propriu-zis anumite "ingrediente",
            // dar pentru simplitate am ales doar sa schimb mesajul afisat.
        }
    }
}
