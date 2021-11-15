using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.creational
{
    namespace builder
    {
        public enum WaterTemperature
        {
            Cold,
            Tepid,
            Boiling
        }

        public enum SugarAdditives
        {
            White,
            Grey
        }

        public enum TeaLeaves
        {
            Green,
            Black
        }

        public class Drink
        {
            public WaterTemperature WaterTemperature { get; set; }
            public SugarAdditives SugarAdditives { get; set; }
            public TeaLeaves TeaLeaves { get; set; }

        }

        public interface IBuilder
        {
            void BoilWater();
            void AddSugar();
            void AddTeaLeaves();
            Drink GetDrink();

        }

        public class Bartender
        {

            public Drink Prepare(IBuilder builder)
            {
                builder.AddTeaLeaves();
                builder.BoilWater();
                builder.AddSugar();
                return builder.GetDrink();
            }
        }

        public class GreenTeaBuilder : IBuilder
        {
            private readonly Drink drink = new Drink();

            public void AddSugar() => drink.SugarAdditives = SugarAdditives.Grey;
            public void AddTeaLeaves() => drink.TeaLeaves = TeaLeaves.Green;
            public void BoilWater() => drink.WaterTemperature = WaterTemperature.Boiling;
            public Drink GetDrink() => drink;
        }

        public class BlackTeaBuilder : IBuilder
        {
            private readonly Drink drink = new Drink();

            public void AddSugar() => drink.SugarAdditives = SugarAdditives.White;
            public void AddTeaLeaves() => drink.TeaLeaves = TeaLeaves.Black;
            public void BoilWater() => drink.WaterTemperature = WaterTemperature.Boiling;
            public Drink GetDrink() => drink;
        }



    }
}
