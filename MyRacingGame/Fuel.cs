using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyRacingGame
{
    public class Fuel
    {
        public int x;
        public int y;
        public Bitmap pic;

        public Fuel(int x, int y, Bitmap pic)
        {
            this.x = x;
            this.y = y;
            this.pic = pic;

        }
        public bool Intersects(Fuel other)
        {
            return this.x < other.x + other.pic.Width &&
             this.x + this.pic.Width > other.x &&
             this.y < other.y + other.pic.Height &&
             this.y + this.pic.Height > other.y;
        }
        public bool IntersectsWithCar(AICars other)
        {
            return this.x < other.x + other.pic.Width &&
            this.x + this.pic.Width > other.x &&
            this.y < other.y + other.pic.Height &&
            this.y + this.pic.Height > other.y;
        }
    }
}
