using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;


namespace MyRacingGame
{
    public static class Pictures
    {
        public static Bitmap car1 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\1.png");
        public static Bitmap car2 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\2.png");
        public static Bitmap car3 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\3.png");
        public static Bitmap car4 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\4.png");
        public static Bitmap car5 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\5.png");
        public static Bitmap car6 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\6.png");
        public static Bitmap car7 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\7.png");
        public static Bitmap car8 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\8.png");
        public static Bitmap fire = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\fire.png");
        public static Bitmap pause = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\pause.png");
        public static Image fuelGif = Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\fuelGif.gif");
        //public static Bitmap car9 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\9.png");
        //public static Bitmap car10 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\10.png");
        //public static Bitmap car11 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\11.png");
        //public static Bitmap car12 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\12.png");
        //public static Bitmap car13 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\13.png");
        //public static Bitmap car14 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\14.png");
        //public static Bitmap car15 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\15.png");
        //public static Bitmap car16 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\16.png");
        //public static Bitmap car17 = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\17.png");

        public static Bitmap Player1car = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\Player1car.png");
      
        public static Bitmap road = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\road500.jpg");

        public static Bitmap gasCan = (Bitmap)Image.FromFile("C:\\Users\\Admin\\Desktop\\MyRacing\\MyRacing\\MyRacingGame\\Pictures\\gasCan.png");
        public static Bitmap RandomCar
        {
            get
            {
                int rand = RandomClass.random.Next(1, 8);
                switch (rand)
                {
                    case 1:
                        return car1;
                    case 2:
                        return car2;
                    case 3:
                        return car3;
                    case 4:
                        return car4;
                    case 5:
                        return car5;
                    case 6:
                        return car6;
                    case 7:
                        return car7;
                    case 8:
                        return car8;
                    //case 9:
                    //    return car9;
                    //case 10:
                    //    return car10;
                    //case 11:
                    //    return car11;
                    //case 12:
                    //    return car12;
                    //case 13:
                    //    return car13;
                    //case 14:
                    //    return car14;
                    //case 15:
                    //    return car15;
                    //case 16:
                    //    return car16;
                    //case 17:
                    //    return car17;
                    default:
                        throw new InvalidOperationException("Unexpected value of rand.");

                }
            }
        }
    }
}
