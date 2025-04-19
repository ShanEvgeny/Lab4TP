using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб4ТП
{
    public abstract class Drink
    {
        protected double Volume = 0;
        public virtual String GetInfo()
        {
            var result = String.Format("\nОбъем:{0}", this.Volume);
            return result;
        }
    }
    public enum UsedFruitInJuice { apple, orange, pear, pomegranate, peach }
    public class Juice : Drink
    {
        protected UsedFruitInJuice fruit = UsedFruitInJuice.apple;
        protected bool IsTherePulp = false;
        public override String GetInfo()
        {
            var result = "Сок";
            result += base.GetInfo();
            result += String.Format("\nИспользованный фрукт: {0}",this.fruit);
            result += String.Format("\nНаличие мякоти: {0}", this.IsTherePulp);
            return result;
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
            result += String.Format("\nВид: {0}", this.type);
            result += String.Format("\nКоличество пузырьков: {0}", this.CountBubbles);
            return result;
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
            result += String.Format("\nТип: {0}", this.type);
            return result;
        }
    }
}
