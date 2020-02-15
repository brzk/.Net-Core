using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public class MainDish : Dish
    {
        public eMainDishTypes Type { get; internal set; }
        public MainDish(string name, int quantity, int dinerSerialNumber, eMainDishTypes mainDishType) : base(name, quantity, dinerSerialNumber)
        {
            Type = mainDishType;
        }
    }
}
