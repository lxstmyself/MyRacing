using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRacingGame
{
    public static class RandomClass
    {
        public static Random random = new Random();
        public static int GetRandom(int min, int max)
        {
            return random.Next(min, max); 
        }
    }
}
