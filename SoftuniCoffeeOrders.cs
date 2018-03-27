
namespace Ladybugs
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            decimal coffeOrders = decimal.Parse(Console.ReadLine());
            decimal Total = 0m;
            for (int i = 0; i < coffeOrders; i++)
            {
                decimal PriceperCapsule = decimal.Parse(Console.ReadLine());
                DateTime OrderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int CapsuleCount = int.Parse(Console.ReadLine());
                decimal dati = DateTime.DaysInMonth(OrderDate.Year, OrderDate.Month);

                decimal Priceforthecofee = dati * CapsuleCount * PriceperCapsule;
                Console.WriteLine($"The price for the coffee is: ${Priceforthecofee:f2}");
                Total += Priceforthecofee;
            }
            Console.WriteLine($"Total: ${Total:f2}");
           

        }

        
    }
}
