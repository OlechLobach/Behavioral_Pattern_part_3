using TemplateMethodPattern.Core;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making Tea...");
            Tea tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking Coffee...");
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}