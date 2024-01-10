using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyRacingGame
{
    public class Statictic
    {
        int currentScore;
        int bestScore;
        double fuel;
        int level;
        int speed;
        public Statictic()
        {
            currentScore = 0;
            bestScore = 0;
            fuel = 100;
            level = 1;
            speed = 80;
        }
        public void IncreaseCurrentScore(int points)
        {
            currentScore += points;
            if (bestScore <= currentScore)
            {
                bestScore += points;
            }
            fuel -= 0.1;
            if (currentScore % 2000 == 0 & level < 10)
            {
                level++;
                speed += 10;
            }
        }
        public void ResetCurrentScore()
        {
            currentScore = 0;
            fuel = 100;
            level = 1;
        }
        public int GetCurrentScore()
        {
            return currentScore;
        }
        public int GetBestScore()
        {
            return bestScore;
        }
        public void RefillFuel(double amount)
        {
            fuel += amount;
            if (fuel > 200) 
            {
                fuel = 200;
            }
        }
        public double GetFuel()
        {
            return Math.Round(fuel, 2);
        }
        public int GetLevel()
        {
            return level;
        }
        public int GetSpeed()
        {
            return speed;
        }
    }
}
