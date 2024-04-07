using System.Runtime.CompilerServices;

namespace CompositionOverInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var choice = 0;
            Pizza pizza = new Pizza();
            do
            {
                Console.Clear();
                choice = ReadChoice(choice);
                if (choice >= 1 && choice <= 3)
                {
                    ITopping topping = null;
                    switch (choice)
                    {
                        case 1:
                            topping = new Mexican();
                            break;
                        case 2:
                            topping = new Chicken();
                            break;
                        case 3:
                            topping = new Cheese();
                            break;
                        default: break;
                    }
                    pizza.AddTopping(topping);
                    Console.WriteLine("Press any key to continue");
                }
                Console.ReadKey();
            } while (choice != 0);
          Console.WriteLine(pizza.ToString());
            Console.ReadKey();
        }

        private static int ReadChoice(int choice)
        {
            Console.WriteLine("Available Topping");
            Console.WriteLine("------------");
            Console.WriteLine("1. Mexican");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Cheese");

            Console.WriteLine("select topping: ");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;
            }

            return choice;
        }
    }
}
/*
 * when use composition over inheritance
 1- when class B has props of class A
  (inheritsnce class B is a class A)
 2- when it's hard to do sth at run time and we have to reopen and code -> compile to make it work
 
 */
class Pizza
{
    public virtual decimal Price => 10m;
    public List<ITopping> toppings { get;private set; } = new List<ITopping>();

   // public void AddTopping(ITopping topping) => Toppings.Add(topping);
    public void AddTopping(ITopping topping)
    {
        toppings.Add(topping);
    }

    public decimal CalcTotalPrice()
    {
        var price = Price;
        foreach (var t in toppings)
        {
            price += t.Price;
        }
        return price;
    }

    public override string ToString()
    {
        var output = $"\n{nameof(Pizza)}";
        output += $"\n\t Base Price {Price.ToString("C")}";
        foreach (var t in toppings)
        {
            output += $"{t.Title}:{t.Price}";
        }
        output += "\n-----------------------";
        output += $"\nTotal: {CalcTotalPrice().ToString("C")}";
        return output;
    }

}
public interface ITopping {
    public string Title { get; }
    public decimal Price { get; }
}

class Mexican : ITopping
{
    public string Title => nameof(Mexican);
    public decimal Price => 2m;
}

class Chicken : ITopping
{
    public string Title => nameof(Chicken);
    public decimal Price => 5m;
}

class Cheese : ITopping
{
    public string Title => nameof(Cheese);
    public decimal Price => 3.5m;
}