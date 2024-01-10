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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;
            closeButton.Location = new Point((this.ClientSize.Width - closeButton.Width) / 2, ((this.ClientSize.Height - closeButton.Height) / 2)+80) ;
            this.Resize += new System.EventHandler(this.Form3_Resize);
        }
        
  
        private void Form3_Resize(object sender, EventArgs e)
        {
            closeButton.Left = (this.ClientSize.Width - closeButton.Width) / 2;
            closeButton.Top = ((this.ClientSize.Height - closeButton.Height) / 2) + 80;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();

           
            Form2 startForm = new Form2();
            startForm.ShowDialog();

           
            this.Show();
        }
    }
}
