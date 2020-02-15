using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public class DishesPrices
    {
        public Dictionary<eDrinkTypes, int> DrinkPrices { get; set; } = new Dictionary<eDrinkTypes, int>()
        {
            { eDrinkTypes.Child, 9 },
            { eDrinkTypes.Soft, 14 },
            { eDrinkTypes.Wine, 33 },
            { eDrinkTypes.Soda, 14 },
            { eDrinkTypes.Bear, 30 }
        };

        public Dictionary<eAppetizerTypes, int> AppetizerPrices { get; set; } = new Dictionary<eAppetizerTypes, int>()
        {
            { eAppetizerTypes.ChickenNuggets , 30 },
            { eAppetizerTypes.ChickenSkewers, 35 },
            { eAppetizerTypes.ChickenWings, 31 }
        };

        public Dictionary<eSaladTypes, int> SaladPrices { get; set; } = new Dictionary<eSaladTypes, int>()
        {
            { eSaladTypes.ClassicSalad, 40 },
            { eSaladTypes.HealthSalad, 42 },
            { eSaladTypes.CeasarSalad, 45 }
        };

        public Dictionary<eMainDishTypes, int> MainDishPrices { get; set; } = new Dictionary<eMainDishTypes, int>()
        {
            { eMainDishTypes.ChickenBreast, 42 },
            { eMainDishTypes.Schnitzel, 55 },
            { eMainDishTypes.SpringChicken, 60 }
        };

        public Dictionary<eSideDishTypes, int> SideDishPrices { get; set; } = new Dictionary<eSideDishTypes, int>()
        {
            { eSideDishTypes.Fries, 15 },
            { eSideDishTypes.Mashed, 15 },
            { eSideDishTypes.OnionRings, 15 },
            { eSideDishTypes.Rice, 15 },
            { eSideDishTypes.Soup, 15 },
            { eSideDishTypes.Salad, 15 }
        };

        public Dictionary<eDessertTypes, int> DessertPrices { get; set; } = new Dictionary<eDessertTypes, int>()
        {
            { eDessertTypes.CremeBrulee, 36 },
            { eDessertTypes.ChocolateCake, 35 },
            { eDessertTypes.Cheesecake, 37 },
            { eDessertTypes.IceCream, 20 }
        };
    }
}
