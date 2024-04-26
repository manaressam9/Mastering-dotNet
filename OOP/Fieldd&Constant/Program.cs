using System.Xml.Linq;

namespace Fieldd_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /* 
           // without using oop
            const double tax = 0.03; //this value is const for all employees
            Console.Write("First Name ");
            var fName = Console.ReadLine();

            Console.Write("Last Name ");
            var lName = Console.ReadLine();

            Console.Write("Wage ");
            var wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hour ");
            var loggedHrs = Convert.ToDouble(Console.ReadLine());

            var netSalary = (wage * loggedHrs )- (wage * loggedHrs * tax);
            Console.WriteLine($"Employee Name: {fName} {lName}");
            Console.WriteLine($"Wage: {wage}");
            Console.WriteLine($"Logged Hour: {loggedHrs}");
            Console.WriteLine($"NET Salary: {netSalary}");
          
           */

            //with OOP
             Employee emp1 = new Employee();
            Console.Write("First Name ");
            emp1.fName = Console.ReadLine();

            Console.Write("Last Name ");
            emp1.lName = Console.ReadLine();

            Console.Write("Wage ");
            emp1.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hour ");
            emp1.loggedHrs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Employee Name: {emp1.fName} {emp1.lName}");
            Console.WriteLine($"Wage: {emp1.wage}");
            Console.WriteLine($"Logged Hour: {emp1.loggedHrs}");
            Console.WriteLine($"NET Salary: {emp1.calcNetSalary(emp1.loggedHrs, emp1.wage)}");

        }
    }
}