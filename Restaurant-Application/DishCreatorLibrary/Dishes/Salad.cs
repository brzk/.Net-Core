using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary.Dishes
{
    public class Salad : Dish
    {
        public eSaladTypes Type { get; internal set; }
        public Salad(string name, int quantity, int dinerSerialNumber, eSaladTypes saladType) : base(name, quantity, dinerSerialNumber)
        {
            Type = saladType;
        }
    }
}
