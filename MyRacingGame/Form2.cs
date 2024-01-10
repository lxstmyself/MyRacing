using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRacingGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelMenu.Left = (this.ClientSize.Width - labelMenu.Width) / 2;
            labelMenu.Top = ((this.ClientSize.Height - labelMenu.Height) / 2)-100;
            startButton.Location = new Point((this.ClientSize.Width - startButton.Width) / 2, ((this.ClientSize.Height - startButton.Height) / 2) + 0);
            rulesButton.Location = new Point((this.ClientSize.Width - rulesButton.Width) / 2, ((this.ClientSize.Height - rulesButton.Height) / 2) + 40);
            this.Resize += new System.EventHandler(this.Form2_Resize);
        }


        private void Form2_Resize(object sender, EventArgs e)
        {
            startButton.Left = (this.ClientSize.Width - startButton.Width) / 2;
            startButton.Top = ((this.ClientSize.Height - startButton.Height) / 2) + 0;
            rulesButton.Left = (this.ClientSize.Width - rulesButton.Width) / 2;
            rulesButton.Top = ((this.ClientSize.Height - rulesButton.Height) / 2) + 40;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();

           
            Form1 gameForm = new Form1();
            gameForm.ShowDialog();

            
            this.Show();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            this.Hide();

         
            Rules rulesForm = new Rules();
            rulesForm.ShowDialog();

        
            this.Show();
        }
    }
}
