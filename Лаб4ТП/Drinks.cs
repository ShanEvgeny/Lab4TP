using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб4ТП
{
    public abstract class Drink
    {
        public double Volume = 0;
        public static Random random = new Random();
        public virtual String GetInfo()
        {
            var result = String.Format("\nОбъем: {0}", this.Volume);
            return result;
        }
    }
    public enum UsedFruitInJuice { 
        apple, 
        orange, 
        pear, 
        pomegranate, 
        peach
    }
    public class Juice : Drink
    {
        protected UsedFruitInJuice fruit = UsedFruitInJuice.apple;
        protected bool IsTherePulp = false;
        public override String GetInfo()
        {
            var result = "Сок";
            result += base.GetInfo();
            result += $"\nИспользованный фрукт: {GetFruit(this.fruit)}";
            result += String.Format("\nНаличие мякоти: {0}", this.IsTherePulp ? "да" : "нет");
            return result;
        }
        public static string GetFruit(UsedFruitInJuice fruit)
        {
            switch (fruit)
            {
                case UsedFruitInJuice.apple:
                    return "яблоко";
                case UsedFruitInJuice.orange:
                    return "апельсин";
                case UsedFruitInJuice.pear:
                    return "груша";
                case UsedFruitInJuice.pomegranate:
                    return "гранат";
                case UsedFruitInJuice.peach:
                    return "персик";
            }
            return "";
        }
        public static Juice Generate()
        {
            return new Juice
            {
                Volume = 1 + random.Next() % 10,
                fruit = (UsedFruitInJuice)random.Next(5),
                IsTherePulp = random.Next() % 2 == 0,
            };
        }
        
    }
    public enum TypeOfSoda { water, lemonade, cola }
    public class Soda : Drink
    {
        protected TypeOfSoda type = TypeOfSoda.cola;
        protected int CountBubbles = 1500;
        public override String GetInfo()
        {
            var result = "Газировка";
            result += base.GetInfo();
            result += String.Format("\nВид: {0}", GetType(this.type));
            result += String.Format("\nКоличество пузырьков: {0}", this.CountBubbles);
            return result;
        }
        public static string GetType(TypeOfSoda type)
        {
            switch (type)
            {
                case TypeOfSoda.water:
                    return "вода";
                case TypeOfSoda.lemonade:
                    return "лемонад";
                case TypeOfSoda.cola:
                    return "кола";
            }
            return "";
        }
        public static Soda Generate()
        {
            return new Soda
            {
                Volume = 1 + random.Next() % 10,
                type = (TypeOfSoda)random.Next(3),
                CountBubbles = 5000 + random.Next() % 5000
            };
        }
    }
    public enum TypeOfAlcohol { wine, beer, cider }
    public class Alcohol : Drink
    {
        protected TypeOfAlcohol type = TypeOfAlcohol.beer;
        protected int Strength = 32;
        public override String GetInfo()
        {
            var result = "Алкоголь";
            result += base.GetInfo();
            result += String.Format("\nКрепость: {0}", this.Strength);
            result += String.Format("\nТип: {0}", GetType(this.type));
            return result;
        }
        public static string GetType(TypeOfAlcohol type)
        {
            switch (type)
            {
                case TypeOfAlcohol.wine:
                    return "вино";
                case TypeOfAlcohol.beer:
                    return "пиво";
                case TypeOfAlcohol.cider:
                    return "сидр";
            }
            return "";
        }
        public static Alcohol Generate()
        {
            return new Alcohol
            {
                Volume = 1 + random.Next() % 10,
                type = (TypeOfAlcohol)random.Next(3),
                Strength = 6 + random.Next() % 30
            };
        }
    }
}
