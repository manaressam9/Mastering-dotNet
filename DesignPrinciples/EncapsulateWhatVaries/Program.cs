using EncapsulateWhatVaries;
namespace EncapsulateWhatVaries
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order(PizzaConstants.cheese);
            Console.WriteLine(pizza.ToString());
            //Console.ReadKey();
        }
    }

    class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        private static Pizza CreateOrder(string type)
        {
            Pizza pizza;
            if (type.Equals(PizzaConstants.cheese))

                pizza = new Cheese();
            else if (type.Equals(PizzaConstants.chicken)) pizza = new Chicken();
            else pizza = new Pizza();

            return pizza;
        }
        public static Pizza Order(string type)
        {
            Pizza pizza = CreateOrder(type);
            // here we should apply encapsulate what varies
            // as the if statements and the type are variables 
            // with respect to the pizza instance amd the prepare,cook,cut methods
           /* if (type.Equals("cheese"))

                pizza = new Cheese();
            else if(type.Equals("chicken")) pizza = new Chicken();
            else pizza = new Pizza();*/
            //
            Prepare();
            Cook();
            Cut();
            return pizza;
        }
        private static void Prepare()
        {
            Console.Write("preparing...");
            Thread.Sleep(500); //5s
            Console.WriteLine("prepared");
        }
        private static void Cook()
        {
            Console.Write("cooking...");
            Thread.Sleep(500); //5s
            Console.WriteLine("cooked");

        }
        private static void Cut()
        {
            Console.Write("cutting...");
            Thread.Sleep(500); //5s
            Console.WriteLine("Done");
        }

        public override string ToString()
        {
            return $"\n{Title} \n price: {Price.ToString("C")}";
        }

    }

    class Cheese : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Cheese)}";
        public override decimal Price => base.Price + 5m;
    }

    class Chicken : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Chicken)}";
        public override decimal Price => base.Price + 15m;
    }
}