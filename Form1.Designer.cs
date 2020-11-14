namespace CAROGAME
{
    partial class Form1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.playerturn = new System.Windows.Forms.TextBox();
            this.prcbCountDown = new System.Windows.Forms.ProgressBar();
            this.picturematch = new System.Windows.Forms.PictureBox();
            this.logocarogame = new System.Windows.Forms.Panel();
            this.panelchessboard = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturematch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txbIP);
            this.panel3.Location = new System.Drawing.Point(655, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 160);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(90, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(78, 128);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(95, 29);
            this.btnLAN.TabIndex = 2;
            this.btnLAN.Text = "connect";
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(37, 103);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(180, 20);
            this.txbIP.TabIndex = 1;
            // 
            // playerturn
            // 
            this.playerturn.BackColor = System.Drawing.SystemColors.Window;
            this.playerturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerturn.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerturn.Location = new System.Drawing.Point(680, 209);
            this.playerturn.Name = "playerturn";
            this.playerturn.Size = new System.Drawing.Size(167, 60);
            this.playerturn.TabIndex = 0;
            // 
            // prcbCountDown
            // 
            this.prcbCountDown.BackColor = System.Drawing.SystemColors.Control;
            this.prcbCountDown.Location = new System.Drawing.Point(390, 34);
            this.prcbCountDown.Name = "prcbCountDown";
            this.prcbCountDown.Size = new System.Drawing.Size(156, 55);
            this.prcbCountDown.TabIndex = 0;
            // 
            // picturematch
            // 
            this.picturematch.BackColor = System.Drawing.Color.Transparent;
            this.picturematch.BackgroundImage = global::CAROGAME.Properties.Resources.mark_background;
            this.picturematch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturematch.ErrorImage = null;
            this.picturematch.InitialImage = null;
            this.picturematch.Location = new System.Drawing.Point(680, 40);
            this.picturematch.Name = "picturematch";
            this.picturematch.Size = new System.Drawing.Size(167, 153);
            this.picturematch.TabIndex = 0;
            this.picturematch.TabStop = false;
            // 
            // logocarogame
            // 
            this.logocarogame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logocarogame.BackColor = System.Drawing.Color.Transparent;
            this.logocarogame.BackgroundImage = global::CAROGAME.Properties.Resources.caro_game_logo;
            this.logocarogame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logocarogame.Location = new System.Drawing.Point(87, 95);
            this.logocarogame.Name = "logocarogame";
            this.logocarogame.Size = new System.Drawing.Size(134, 143);
            this.logocarogame.TabIndex = 1;
            // 
            // panelchessboard
            // 
            this.panelchessboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelchessboard.BackColor = System.Drawing.Color.Transparent;
            this.panelchessboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelchessboard.Location = new System.Drawing.Point(316, 95);
            this.panelchessboard.Name = "panelchessboard";
            this.panelchessboard.Size = new System.Drawing.Size(295, 289);
            this.panelchessboard.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CAROGAME.Properties.Resources.chessdrawing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 476);
            this.Controls.Add(this.panelchessboard);
            this.Controls.Add(this.playerturn);
            this.Controls.Add(this.picturematch);
            this.Controls.Add(this.prcbCountDown);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.logocarogame);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Q&A CARO GAME";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturematch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel logocarogame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox playerturn;
        private System.Windows.Forms.ProgressBar prcbCountDown;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.PictureBox picturematch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelchessboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

