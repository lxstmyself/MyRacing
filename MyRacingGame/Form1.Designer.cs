
namespace MyRacingGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.BestScore = new System.Windows.Forms.Label();
            this.CountOfFuel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Level = new System.Windows.Forms.Label();
            this.fuelGifBox = new System.Windows.Forms.PictureBox();
            this.speedScore = new System.Windows.Forms.Label();
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.pauseLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelGifBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(800, 450);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // CurrentScore
            // 
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.BackColor = System.Drawing.Color.Transparent;
            this.CurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentScore.Location = new System.Drawing.Point(3, 40);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(69, 17);
            this.CurrentScore.TabIndex = 1;
            this.CurrentScore.Text = "Score: 0";
            // 
            // BestScore
            // 
            this.BestScore.AutoSize = true;
            this.BestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestScore.Location = new System.Drawing.Point(3, 14);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(106, 17);
            this.BestScore.TabIndex = 2;
            this.BestScore.Text = "Best Score: 0";
            // 
            // CountOfFuel
            // 
            this.CountOfFuel.AutoSize = true;
            this.CountOfFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfFuel.Location = new System.Drawing.Point(33, 94);
            this.CountOfFuel.Name = "CountOfFuel";
            this.CountOfFuel.Size = new System.Drawing.Size(76, 17);
            this.CountOfFuel.TabIndex = 3;
            this.CountOfFuel.Text = "Fuel: 0 %";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level.Location = new System.Drawing.Point(4, 67);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(66, 17);
            this.Level.TabIndex = 5;
            this.Level.Text = "Level: 1";
            // 
            // fuelGifBox
            // 
            this.fuelGifBox.BackColor = System.Drawing.Color.Transparent;
            this.fuelGifBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelGifBox.Image = ((System.Drawing.Image)(resources.GetObject("fuelGifBox.Image")));
            this.fuelGifBox.Location = new System.Drawing.Point(0, 0);
            this.fuelGifBox.Name = "fuelGifBox";
            this.fuelGifBox.Size = new System.Drawing.Size(800, 450);
            this.fuelGifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fuelGifBox.TabIndex = 6;
            this.fuelGifBox.TabStop = false;
            // 
            // speedScore
            // 
            this.speedScore.AutoSize = true;
            this.speedScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedScore.Location = new System.Drawing.Point(4, 122);
            this.speedScore.Name = "speedScore";
            this.speedScore.Size = new System.Drawing.Size(125, 17);
            this.speedScore.TabIndex = 7;
            this.speedScore.Text = "Speed: 80 KM/H";
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountdownLabel.Location = new System.Drawing.Point(363, 170);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(64, 69);
            this.CountdownLabel.TabIndex = 8;
            this.CountdownLabel.Text = "3";
            this.CountdownLabel.Visible = false;
            // 
            // pauseLable
            // 
            this.pauseLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pauseLable.AutoSize = true;
            this.pauseLable.BackColor = System.Drawing.Color.Black;
            this.pauseLable.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLable.ForeColor = System.Drawing.Color.DarkRed;
            this.pauseLable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pauseLable.Location = new System.Drawing.Point(305, 170);
            this.pauseLable.Name = "pauseLable";
            this.pauseLable.Size = new System.Drawing.Size(185, 57);
            this.pauseLable.TabIndex = 9;
            this.pauseLable.Text = "P A U S E";
            this.pauseLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speedScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CountOfFuel);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.CurrentScore);
            this.Controls.Add(this.BestScore);
            this.Controls.Add(this.pauseLable);
            this.Controls.Add(this.CountdownLabel);
            this.Controls.Add(this.fuelGifBox);
            this.Controls.Add(this.MainPictureBox);
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelGifBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Label CurrentScore;
        private System.Windows.Forms.Label BestScore;
        private System.Windows.Forms.Label CountOfFuel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.PictureBox fuelGifBox;
        private System.Windows.Forms.Label speedScore;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.Label pauseLable;
    }
}

