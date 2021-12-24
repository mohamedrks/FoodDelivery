using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class PostcodeLookup : IPostcodeLookup
    {

        private static Dictionary<string, string[]> PostalCodeDictionary = new Dictionary<string, string[]>();


        public PostcodeLookup()
        {
            LoadDeliveryOptions();
        }

        public string[] GetValidDeliveryOptions(string postcode)
        {
            string[] val;

            if (PostalCodeDictionary.TryGetValue(postcode ,out val)) {
                return val;
            }
      
            return new string[] { "Delivery by Courier" };   
        }

        private void LoadDeliveryOptions()
        {
            PostalCodeDictionary.Add("TN13",new string[] { "Delivery from Sevenoaks", "Collect from Sevenoaks" });
            PostalCodeDictionary.Add("TN15", new string[] { "Collect from Sevenoaks" });
            PostalCodeDictionary.Add("ME10", new string[] { "Collect from Kitchen" });
            PostalCodeDictionary.Add("TN9", new string[] { "Delivery from Warehouse" });
            PostalCodeDictionary.Add("TN9 1AP", new string[] {"No Deliveries" });
            
        }
    }
}
