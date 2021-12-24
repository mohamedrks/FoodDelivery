using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PostcodeLookup pcodeLookupObj = new PostcodeLookup();

            var res = pcodeLookupObj.GetValidDeliveryOptions("TN9");
            foreach (var r in res)
            {
                Console.Write( r + "  ");
            }
        }
    }
}
