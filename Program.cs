using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class Program
    {
        public class Products
        {
            public decimal Price { get; set; }
            public string Type { get; set; }
        }
        public static void Main()
        {
            decimal currency = 0m, returnedcurrency=0m, change=0m;
            string type;

            List<Products> product = new List<Products>
            {
                new Products(){Price=2.00m, Type="Cookies"},
                new Products(){Price=1.00m, Type="Chips"},
                new Products(){Price=0.50m, Type="Chocolate"},
                new Products(){Price=2.75m, Type="Skittles"},
                new Products(){Price=2.00m, Type="Pop"},
                new Products(){Price=2.25m, Type="Danish"},
            };

            foreach (Products p in product)
                Console.WriteLine(p.Type + " " + p.Price);


            Console.WriteLine("\nPlease enter the type of snack you want: ");
            type = Console.ReadLine();
            Console.WriteLine("\nEnter the amount of money paid: ");
            currency = decimal.Parse(Console.ReadLine());

            //Console.WriteLine(type + " {0:C2}", currency); //Checking the correct assignment.

            returnedcurrency = ProductCatelog(type);
            Console.WriteLine(returnedcurrency);

            change=Vending(currency, returnedcurrency);

            Console.ReadLine();//Stopping the Console Window
        }
        public static decimal Vending(decimal currency, decimal snackprice)
        {
            decimal dollar = 1m, quarter = .25m, dime = .10m, nickel = .05m;


        }
        public static decimal ProductCatelog(string type)
        {
            for (int i = 0; i < 6; i++)
            {
                if (StringComparison.OrdinalIgnoreCase(type, List<i>))
                {
                    return Products.Price.GetType;
                };
            }
        }

    }
}