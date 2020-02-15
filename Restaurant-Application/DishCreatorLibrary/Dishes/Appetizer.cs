using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public class Appetizer : Dish
    {
        public eAppetizerTypes Type { get; internal set; }
        public Appetizer(string name, int quantity, int dinerSerialNumber, eAppetizerTypes appetizerType) : base(name, quantity, dinerSerialNumber)
        {
            Type = appetizerType;
        }
    }
}
