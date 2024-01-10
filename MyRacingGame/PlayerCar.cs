using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyRacingGame
{
    public class PlayerCar
    {
        public int x;
        public int y;
        public Bitmap pic;

        public PlayerCar(int x, int y, Bitmap pic)
        {
            this.x = x;
            this.y = y;
            this.pic = pic;

        }
        
    }
}
