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
            this.components = new System.ComponentModel.Container();
            this.playerturn = new System.Windows.Forms.TextBox();
            this.prcbCountDown = new System.Windows.Forms.ProgressBar();
            this.picturematch = new System.Windows.Forms.PictureBox();
            this.logocarogame = new System.Windows.Forms.Panel();
            this.panelchessboard = new System.Windows.Forms.Panel();
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picturematch)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerturn
            // 
            this.playerturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerturn.BackColor = System.Drawing.SystemColors.Window;
            this.playerturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerturn.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerturn.Location = new System.Drawing.Point(633, 209);
            this.playerturn.Name = "playerturn";
            this.playerturn.Size = new System.Drawing.Size(228, 60);
            this.playerturn.TabIndex = 0;
            this.playerturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prcbCountDown
            // 
            this.prcbCountDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prcbCountDown.BackColor = System.Drawing.SystemColors.Control;
            this.prcbCountDown.Location = new System.Drawing.Point(377, 34);
            this.prcbCountDown.Name = "prcbCountDown";
            this.prcbCountDown.Size = new System.Drawing.Size(156, 51);
            this.prcbCountDown.TabIndex = 0;
            // 
            // picturematch
            // 
            this.picturematch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturematch.BackColor = System.Drawing.Color.Transparent;
            this.picturematch.BackgroundImage = global::CAROGAME.Properties.Resources.mark_background;
            this.picturematch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturematch.ErrorImage = null;
            this.picturematch.InitialImage = null;
            this.picturematch.Location = new System.Drawing.Point(680, 40);
            this.picturematch.Name = "picturematch";
            this.picturematch.Size = new System.Drawing.Size(142, 149);
            this.picturematch.TabIndex = 0;
            this.picturematch.TabStop = false;
            // 
            // logocarogame
            // 
            this.logocarogame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logocarogame.BackColor = System.Drawing.Color.Transparent;
            this.logocarogame.BackgroundImage = global::CAROGAME.Properties.Resources.caro_game_logo;
            this.logocarogame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logocarogame.Location = new System.Drawing.Point(65, 95);
            this.logocarogame.Name = "logocarogame";
            this.logocarogame.Size = new System.Drawing.Size(160, 163);
            this.logocarogame.TabIndex = 1;
            // 
            // panelchessboard
            // 
            this.panelchessboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelchessboard.BackColor = System.Drawing.Color.Transparent;
            this.panelchessboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelchessboard.Location = new System.Drawing.Point(291, 106);
            this.panelchessboard.Name = "panelchessboard";
            this.panelchessboard.Size = new System.Drawing.Size(289, 315);
            this.panelchessboard.TabIndex = 0;
            // 
            // tmCountDown
            // 
            this.tmCountDown.Tick += new System.EventHandler(this.tmCountDown_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(873, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Setting";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CAROGAME.Properties.Resources._125341518_2718673668383698_7625456457369883024_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 527);
            this.Controls.Add(this.panelchessboard);
            this.Controls.Add(this.playerturn);
            this.Controls.Add(this.picturematch);
            this.Controls.Add(this.prcbCountDown);
            this.Controls.Add(this.logocarogame);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "BINGO QUIZ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picturematch)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel logocarogame;
        private System.Windows.Forms.TextBox playerturn;
        private System.Windows.Forms.ProgressBar prcbCountDown;
        private System.Windows.Forms.PictureBox picturematch;
        private System.Windows.Forms.Panel panelchessboard;
        private System.Windows.Forms.Timer tmCountDown;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}

