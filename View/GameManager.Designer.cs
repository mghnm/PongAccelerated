namespace PongAccelerated
{
    partial class GameManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.relaylabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ballPic = new System.Windows.Forms.PictureBox();
            this.paddlePicP2 = new System.Windows.Forms.PictureBox();
            this.paddlePicP1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddlePicP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddlePicP1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.ForeColor = System.Drawing.Color.White;
            this.lblP1.Location = new System.Drawing.Point(261, 28);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(46, 59);
            this.lblP1.TabIndex = 3;
            this.lblP1.Text = "0";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.ForeColor = System.Drawing.Color.White;
            this.lblP2.Location = new System.Drawing.Point(948, 28);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(46, 59);
            this.lblP2.TabIndex = 4;
            this.lblP2.Text = "0";
            // 
            // relaylabel
            // 
            this.relaylabel.AutoSize = true;
            this.relaylabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relaylabel.ForeColor = System.Drawing.Color.White;
            this.relaylabel.Location = new System.Drawing.Point(536, 633);
            this.relaylabel.Name = "relaylabel";
            this.relaylabel.Size = new System.Drawing.Size(183, 39);
            this.relaylabel.TabIndex = 5;
            this.relaylabel.Text = "Rally Counter: 0";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(499, 93);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(276, 77);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "Game Over";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(474, 523);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(325, 77);
            this.startLabel.TabIndex = 7;
            this.startLabel.Text = "Press SPACE";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.White;
            this.winnerLabel.Location = new System.Drawing.Point(462, 193);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(337, 77);
            this.winnerLabel.TabIndex = 8;
            this.winnerLabel.Text = "Player 0 wins";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(409, 102);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(439, 77);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Pong: Accelerated";
            // 
            // ballPic
            // 
            this.ballPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ballPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.ballPic.Image = global::PongAccelerated.Properties.Resources.Square;
            this.ballPic.Location = new System.Drawing.Point(620, 337);
            this.ballPic.Margin = new System.Windows.Forms.Padding(0);
            this.ballPic.Name = "ballPic";
            this.ballPic.Size = new System.Drawing.Size(25, 25);
            this.ballPic.TabIndex = 2;
            this.ballPic.TabStop = false;
            // 
            // paddlePicP2
            // 
            this.paddlePicP2.Image = global::PongAccelerated.Properties.Resources.Paddle;
            this.paddlePicP2.Location = new System.Drawing.Point(1244, 245);
            this.paddlePicP2.Margin = new System.Windows.Forms.Padding(0);
            this.paddlePicP2.Name = "paddlePicP2";
            this.paddlePicP2.Size = new System.Drawing.Size(20, 200);
            this.paddlePicP2.TabIndex = 1;
            this.paddlePicP2.TabStop = false;
            // 
            // paddlePicP1
            // 
            this.paddlePicP1.Image = global::PongAccelerated.Properties.Resources.Paddle;
            this.paddlePicP1.Location = new System.Drawing.Point(-1, 230);
            this.paddlePicP1.Margin = new System.Windows.Forms.Padding(0);
            this.paddlePicP1.Name = "paddlePicP1";
            this.paddlePicP1.Size = new System.Drawing.Size(20, 200);
            this.paddlePicP1.TabIndex = 0;
            this.paddlePicP1.TabStop = false;
            // 
            // GameManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.relaylabel);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.ballPic);
            this.Controls.Add(this.paddlePicP2);
            this.Controls.Add(this.paddlePicP1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong: Accelerated";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameManager_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameManager_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddlePicP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddlePicP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox paddlePicP1;
        private System.Windows.Forms.PictureBox paddlePicP2;
        private System.Windows.Forms.PictureBox ballPic;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label relaylabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

