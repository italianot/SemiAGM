using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiAGM
{
    public class Weather
    {
        public static Random rnd = new Random();
        public int t = 0; // температура
        public virtual String GetInfo()
        {
            var str = String.Format("\nТемпература: {0} °C", this.t);
            return str;
        }
    }

    public class Sun : Weather
    {
        public int HeightOfTheSun = 0; // высота солнца над горизонтом
        public bool Wind = false; // наличие ветерка

        public override String GetInfo()
        {
            var str = "Солнце";
            str += base.GetInfo();
            str += String.Format("\nВысота солнца над горизонтом: {0}°", this.HeightOfTheSun);
            if (this.Wind == true) {
                str += String.Format("\nCвежий ветерок присутствует");
            }
            else
            {
                str += String.Format("\nCвежий ветерок отсутствует");
            }
            return str;
        }

        public static Sun Generate()
        {
            return new Sun
            {
                t = rnd.Next(15) + 20, // Температура от 10 до 35
                HeightOfTheSun = rnd.Next(45) + 45, // высота солнца от 45 до 90 в градусах
                Wind = rnd.Next() % 2 == 0 // наличие ветра true или false
            };
        }
    }

    public class Rain : Weather
    {
        public int Precipitation = 0; // осадки
        public bool Rainbow = false; // наличие радуги
        public bool Storm = true; // наличие грозы

        public override String GetInfo()
        {
            var str = "Дождь";
            str += base.GetInfo();
            str += String.Format("\nВеличина осадков: {0} см", this.Precipitation);
            if (this.Rainbow == true)
            {
                str += String.Format("\nРадуга сияет в небе (*♡∀♡)");
            }
            else
            {
                str += String.Format("\nНет радуги ٩(╬ʘ益ʘ╬)۶");
            }
            if (this.Storm == true)
            {
                str += String.Format("\nДует свежий ветерок");
            }
            else
            {
                str += String.Format("\nШтиль - ветер молчит\nУпал белой чайкой на дно\nШтиль - наш корабль забыт\nОдин, в мире скованном сном...");
            }
            return str;
        }
        public static Rain Generate()
        {
            return new Rain
            {
                t = rnd.Next(7) + 5, // Температура от 5 до 12
                Precipitation = rnd.Next(10), // величина осадков от 0 до 10 в см
                Rainbow = rnd.Next() % 2 == 0, // наличие радуги true или false
                Storm = rnd.Next() % 2 == 0 // наличие грозы true или false
            };
        }
    }

    public enum SnowType { Хлопья, Мелкий };
    public class Snow : Weather
    {
        public SnowType type = SnowType.Хлопья; // тип снега
        public int HeightOfTheSnow = 0; // высота снега

        public override String GetInfo()
        {
            var str = "Снег";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.type);
            str += String.Format("\nВысота снега: {0} см", this.HeightOfTheSnow);

            return str;
        }
        public static Snow Generate()
        {
            return new Snow
            {
                t = rnd.Next(5), // Температура от 0 до 5
                type = (SnowType)rnd.Next(2), // тип снега
                HeightOfTheSnow = rnd.Next(20) // высота снега от 0 до 20 в см
            };
        }
    }

}