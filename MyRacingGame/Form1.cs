using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyRacingGame
{
    public partial class Form1 : Form
    {

        public bool pressP;
        public bool pressLeft, pressRight;

        public int frame;
        public Bitmap screenB;
        public Graphics screenG;
    

        public PlayerCar player1Car;
        //
        public List<AICars> cars;
        public List<Fuel> fuelCans;

        Statictic currentScore;

        public int lvl;
        public int countdown;
   
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            pressLeft = false;
            pressRight = false;
            
            //
            //

            frame = 0;
            screenB = new Bitmap(500, 500);
            screenG = Graphics.FromImage(screenB);
          

            player1Car = new PlayerCar(212, 400, Pictures.Player1car);
            //
            cars = new List<AICars>();
            fuelCans = new List<Fuel>();

            MainPictureBox.Image = screenB;

            currentScore = new Statictic();
            fuelGifBox.Visible = false;
            CountdownTimer.Start();
            countdown = 3;
            timer1.Enabled = false;
            pauseLable.Visible = false;
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
        public void UpdateGraphics()
        {
             screenG.DrawImage(Pictures.road, new Point(0, frame * (25 + lvl) % 500 - 500));
             screenG.DrawImage(player1Car.pic, new Point(player1Car.x, player1Car.y));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            frame = frame + 1;
            MainPictureBox.Invalidate();

            UpdateGraphics();
        
            lvl = currentScore.GetLevel();

            // AI Cars
            foreach (AICars c in cars)
            {
                screenG.DrawImage(c.pic, c.x, c.y);
            }
            foreach (AICars c in cars)
            {
               
                if (lvl < 10)
                {
                    c.y += 2 + lvl;
                }
                else
                {
                    c.y += lvl;
                }
            }
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].y > 500)
                {
                    cars.RemoveAt(i);
                }
            }
            if (RandomClass.GetRandom(0, 6) == 5)
            {
                int newX = RandomClass.GetRandom(10, 412);
                int newY = -20;
                AICars newCar = new AICars(newX, newY, Pictures.RandomCar);

                bool canAddCar = true;
                foreach (AICars c in cars)
                {
                    if (newCar.Intersects(c))
                    {
                        canAddCar = false;
                        break;
                    }
                }

                if (canAddCar)
                {
                    cars.Add(newCar);
                }
            }

            // Fuel
            foreach (Fuel c in fuelCans)
            {
                screenG.DrawImage(c.pic, c.x, c.y);
            }
            foreach (Fuel c in fuelCans)
            {
                if (lvl < 10)
                {
                    c.y += 2 + lvl;
                }
                else
                {
                    c.y += lvl;
                }
            }
            for (int i = 0; i < fuelCans.Count; i++)
            {
                Fuel c = fuelCans[i];

                int carRight = player1Car.x + 56;  
                int carBottom = player1Car.y + 64; 

                if (c.x >= player1Car.x && c.x <= carRight && c.y >= player1Car.y && c.y <= carBottom)
                {
                    fuelCans.Remove(c);
                    currentScore.RefillFuel(30);
                    Sound.takeGas.Play();
                }
            }
            if (RandomClass.GetRandom(0, 200) == 50) 
            {
                int newX = RandomClass.GetRandom(20, 400);
                int newY = -20;
                Fuel newFuelCan = new Fuel(newX, newY, Pictures.gasCan);  
             
                bool canAddCan = true;
                foreach (Fuel c in fuelCans)
                {
                  
                    if (newFuelCan.Intersects(c)) 
                    {
                        canAddCan = false;
                        break;
                    }
                    foreach (AICars car in cars)
                    {
                        if (newFuelCan.IntersectsWithCar(car))
                        {
                            canAddCan = false;
                            break;
                        }
                    }
                }

                if (canAddCan)
                {
                    fuelCans.Add(newFuelCan);
                }
            }

            //Car Crash
            foreach (AICars c in cars)
            {
                int difX = Math.Abs(player1Car.x - c.x);
                int difY = Math.Abs(player1Car.y - c.y);
                if (difX < 28 && difY < 65 )
                {
                    timer1.Enabled = false;

                    Sound.explosion.Play();

                    screenG.DrawImage(Pictures.fire, new Point(player1Car.x+20, player1Car.y));
                    screenG.DrawImage(Pictures.fire, new Point(player1Car.x + 20, player1Car.y+20));
                    screenG.DrawImage(Pictures.fire, new Point(player1Car.x + 20, player1Car.y+40));

                    DialogResult result = MessageBox.Show("YOU CRASHED! Do you want to restart?", "DEFEAT", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        RestartGame();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }

            }

            //Empty Fuel
            if (currentScore.GetFuel() <= 0)
            {
                fuelGifBox.Left = (this.ClientSize.Width - fuelGifBox.Width) / 2;
                fuelGifBox.Top = ((this.ClientSize.Height - fuelGifBox.Height) / 2);
                timer1.Enabled = false;
                fuelGifBox.Visible = true;
                DialogResult result = MessageBox.Show("YOU RAN OUT OF FUEL! Do you want to restart?", "DEFEAT", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    RestartGame();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }

            //Score
            CurrentScore.Text = "Score: " + currentScore.GetCurrentScore();
            BestScore.Text = "Best Score: " + currentScore.GetBestScore();
            CountOfFuel.Text = $"Fuel: {currentScore.GetFuel()} %";
            Level.Text = "Level: " + lvl;
            speedScore.Text = $"Speed: {currentScore.GetSpeed()} KM/H"; 
            currentScore.IncreaseCurrentScore(1);

            //Movement
            if (pressLeft)
            {
                player1Car.x -= 5;
            }
            if (pressRight)
            {
                player1Car.x += 5;
            }
            if (player1Car.x > 412)
            {
                player1Car.x = 412;
            }
            if (player1Car.x < 10)
            {
                player1Car.x = 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                pressLeft = true;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                pressRight = true;
            }
            if (e.KeyCode == Keys.P)
            {
                if (!pressP)
                {
                    pressP = true;
                    timer1.Enabled = false;
                    pauseLable.Visible = true;
                }
                else
                {
                    pressP = false;
                    timer1.Enabled = true;
                    pauseLable.Visible = false;
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                pressLeft = false;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                pressRight = false;
            }
            if (e.KeyCode == Keys.P)
            {
                if (!pressP)  
                {
                    pressP = false;  
                    timer1.Enabled = true;  
                    pauseLable.Visible = false; 
                }

            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {        
            if (countdown > 0)
            {
              
                CountdownLabel.Left = (this.ClientSize.Width - CountdownLabel.Width) / 2;
                CountdownLabel.Top = ((this.ClientSize.Height - CountdownLabel.Height) / 2);
                CountdownLabel.Text = countdown.ToString();
                CountdownLabel.Visible = true;
                fuelGifBox.Visible = false;
                countdown--;
                Sound.countdown.Play();
            }
            else if (countdown <= 0)
            {
                Sound.countdown.Stop();

                timer1.Enabled = true;
                CountdownTimer.Stop();
                CountdownLabel.Visible = false;
                MainPictureBox.Visible = true;
            }
        }
        public void RestartGame()
        {
            currentScore.ResetCurrentScore();
            
            cars = new List<AICars>();
            fuelCans = new List<Fuel>();
            player1Car.x = 212;
            player1Car.y = 400;
            pressLeft = false;
            pressRight = false;

            RestartCountdown();
        }
        private void RestartCountdown()
        {       
            countdown = 3;
            CountdownTimer.Start();   
            MainPictureBox.Visible = false;
        }
    }
}
