using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public class InitializeDishes
    {

        public Appetizer InitializeAppetizer(string name, int quantity, int dinerSerialNumber, eAppetizerTypes appetizerType)
        {
            //DishBuilder<Appetizer> dishBuilder1 = new 
            AppetizerBuilder appetizerBuilder = new AppetizerBuilder();

            Appetizer appetizer = appetizerBuilder.BuildDish(name, quantity, dinerSerialNumber, appetizerType);

            return appetizer;

            //DishBuilders.DishBuilders.AppetizerBuilder.Appetizer = new Appetizer(name, quantity, dinerSerialNumber, appetizerType);
            //DishBuilders.Director.SetDishRanks(DishBuilders.DishBuilders.AppetizerBuilder);

            //return DishBuilders.DishBuilders.AppetizerBuilder.Appetizer;
        }

        //public  MainDish InitializeMainDish(string name, int quantity, int dinerSerialNumber, eMainDishTypes mainDishType)
        //{
        //    DishBuilders.DishBuilders.MainDishBuilder.MainDish = new MainDish(name, quantity, dinerSerialNumber, mainDishType);
        //    DishBuilders.Director.SetDishRanks(DishBuilders.DishBuilders.MainDishBuilder);

        //    return DishBuilders.DishBuilders.MainDishBuilder.MainDish;
        //}

    }
}
