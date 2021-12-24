using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public interface IPostcodeLookup
    {
        string[] GetValidDeliveryOptions(string postcode);
    }
}
