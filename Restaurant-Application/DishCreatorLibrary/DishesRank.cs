using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public class DishesRank
    {
        public Dictionary<eDishTypes, int> DishTypesRank { get; set; } = new Dictionary<eDishTypes, int>()
        {
            { eDishTypes.Drink, 1 },
            { eDishTypes.Appetizer, 2 },
            { eDishTypes.Salad, 2 },
            { eDishTypes.MainDish, 4 },
            { eDishTypes.SideDish, 5 },
            { eDishTypes.Dessert, 6 }
        };

        public Dictionary<eDrinkTypes, int> DrinkRanks { get; set; } = new Dictionary<eDrinkTypes, int>()
        {
            { eDrinkTypes.Child, 1 },
            { eDrinkTypes.Soft, 2 },
            { eDrinkTypes.Wine, 3 },
            { eDrinkTypes.Soda, 4 },
            { eDrinkTypes.Bear, 5 }
        };

        public Dictionary<eAppetizerTypes, int> AppetizerRanks { get; set; } = new Dictionary<eAppetizerTypes, int>()
        {
            { eAppetizerTypes.ChickenNuggets, 1 },
            { eAppetizerTypes.ChickenSkewers, 2 },
            { eAppetizerTypes.ChickenWings, 3 }
        };

        public Dictionary<eSaladTypes, int> SaladRanks { get; set; } = new Dictionary<eSaladTypes, int>()
        {
            { eSaladTypes.ClassicSalad, 1 },
            { eSaladTypes.HealthSalad, 2 },
            { eSaladTypes.CeasarSalad, 3 }
        };

        public Dictionary<eMainDishTypes, int> MainDishRanks { get; set; } = new Dictionary<eMainDishTypes, int>()
        {
            { eMainDishTypes.ChickenBreast, 1 },
            { eMainDishTypes.Schnitzel, 2 },
            { eMainDishTypes.SpringChicken, 3 }
        };

        public Dictionary<eSideDishTypes, int> SideDishRanks { get; set; } = new Dictionary<eSideDishTypes, int>()
        {
            { eSideDishTypes.Fries, 1 },
            { eSideDishTypes.Mashed, 2 },
            { eSideDishTypes.OnionRings, 3 },
            { eSideDishTypes.Rice, 4 },
            { eSideDishTypes.Soup, 5 },
            { eSideDishTypes.Salad, 6 }
        };

        public Dictionary<eDessertTypes, int> DessertRanks { get; set; } = new Dictionary<eDessertTypes, int>()
        {
            { eDessertTypes.CremeBrulee, 1 },
            { eDessertTypes.ChocolateCake, 2 },
            { eDessertTypes.Cheesecake, 3 },
            { eDessertTypes.IceCream, 4 }
        };
    }
}
