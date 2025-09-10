// HW1a Sales Total

// Your Name: Sarah Cardillo
// Did you seek help ? If yes, specify the helper or web link here: Yes, pooja. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sales_Tax = 0.085;
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string ProductName = Console.ReadLine();

            Console.WriteLine("How many football tickets do you want to buy?");
            int Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the price for each football ticket?");
            double Price = Convert.ToDouble(Console.ReadLine());

            double Subtotal = Quantity * Price;
            double Tax = Subtotal * Sales_Tax;
            double Total = Subtotal + Tax;

            Console.WriteLine("Your subtotal for your bill is $" + Subtotal.ToString("F2"));
            Console.WriteLine("The sales tax for your bill is $" + Tax.ToString("F2"));
            Console.WriteLine("Your total for your bill is $" + Total.ToString("F2"));

            Console.ReadKey();
        }
    }
}
