using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{


    public class Products
    {
        public decimal Price { get; set; }
        public string Type { get; set; }
    }

    public class Program
    {
        public static Products Catalog(int j)
        {
            Products[] array = new Products[]
            {
            new Products() { Price = 2.00m, Type = "cookies" },
            new Products() { Price = 1.00m, Type = "chips" },
            new Products() { Price = 0.50m, Type = "chocolate" },
            new Products() { Price = 2.75m, Type = "skittles" },
            new Products() { Price = 2.00m, Type = "pop" },
            new Products() { Price = 2.25m, Type = "danish" },
            };

            return array[j];
        }
        public static void Main()
        {
            decimal currency = 0m, change = 0m, total = 0m;
            string type = "0";
            Console.WriteLine("***Vending Machine***\n");
            VendingMachine();//Show All Products

            Console.WriteLine("\nPlease enter the type of snack you want: (Enter 99 to indicate end of order)");
            type = Console.ReadLine();

            while (type != "99")
            {

                if (type != "99")
                {
                    type.ToLower();
                    total = SnackTotal(type, total);
                    Console.WriteLine("Total is {0:C2}", total);
                }
                else
                {
                    break;
                }
                Console.WriteLine("\nPlease enter the type of snack you want: (Enter 99 to indicate end of order)");
                type = Console.ReadLine();
            }
            Console.WriteLine("Total is {0:C2}", total);

            while (change <= 0)
            {
                Console.WriteLine("\nHow many Dollars are you entering? ");
                currency += decimal.Parse(Console.ReadLine());
                Console.WriteLine("\nHow many Quarters are you entering? ");
                currency += (decimal.Parse(Console.ReadLine()) * 0.25m);
                Console.WriteLine("\nHow many Dimes are you entering? ");
                currency += (decimal.Parse(Console.ReadLine()) * 0.10m);
                Console.WriteLine("\nHow many Nickels are you entering? ");
                currency += (decimal.Parse(Console.ReadLine()) * 0.05m);
                change = Vending(currency, total);
                if (change >= 0)
                {
                    Console.WriteLine("\nYour change is {0:C2}", change);
                    Console.WriteLine("\nThank you! Have a great day!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou still owe {0:C2}", currency);
                    Console.WriteLine("\nPlease enter more money.");
                    continue;
                }
            }
            Console.ReadLine();//Stopping the Console Window from closing.
        }
        public static void VendingMachine()
        {
            Products[] array2 = new Products[6];

            for (int i = 0; i < 6; i++)
            {
                array2[i] = Catalog(i);
            }

            foreach (Products p in array2)
                Console.WriteLine(p.Type + " {0:C2}", p.Price);
        }
        public static decimal Vending(decimal entry, decimal snackprice)
        {
            decimal change = 0m;

            change = entry - snackprice;

            return change;


        }
        public static decimal SnackTotal(string snack, decimal outsidetotal)//Calculates total.
        {
            decimal total = outsidetotal;
            string type;
            int flag;

            for (int i = 0; i < 6; i++)
            {
                type = Catalog(i).Type;

                flag = String.Compare(type, snack);

                if (flag == 0)
                {
                    total += Catalog(i).Price;
                }
            }
            return total;
        }
    }
}