using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public class DishesPrices
    {
        public Dictionary<eAppetizerTypes, int> AppetizerPrices = new Dictionary<eAppetizerTypes, int>()
        {
            { eAppetizerTypes.ChickenNuggets , 30 },
            { eAppetizerTypes.ChickenSkewers, 35 },
            { eAppetizerTypes.ChickenWings, 31 }
        };

        public Dictionary<eMainDishTypes, int> MainDishPrices = new Dictionary<eMainDishTypes, int>()
        {
            { eMainDishTypes.ChickenBreast, 42 },
            { eMainDishTypes.Schnitzel, 55 },
            { eMainDishTypes.SpringChicken, 60 }
        };
    }
}
