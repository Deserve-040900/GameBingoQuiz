namespace CAROGAME
{
    partial class Form2
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
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonsetting = new System.Windows.Forms.Button();
            this.buttonguide = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonstart
            // 
            this.buttonstart.BackColor = System.Drawing.Color.Transparent;
            this.buttonstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonstart.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.buttonstart.FlatAppearance.BorderSize = 0;
            this.buttonstart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonstart.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstart.Location = new System.Drawing.Point(639, 117);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(148, 55);
            this.buttonstart.TabIndex = 0;
            this.buttonstart.Text = "START";
            this.buttonstart.UseVisualStyleBackColor = false;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonsetting
            // 
            this.buttonsetting.BackColor = System.Drawing.Color.Transparent;
            this.buttonsetting.FlatAppearance.BorderSize = 0;
            this.buttonsetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonsetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsetting.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsetting.Location = new System.Drawing.Point(620, 178);
            this.buttonsetting.Name = "buttonsetting";
            this.buttonsetting.Size = new System.Drawing.Size(176, 55);
            this.buttonsetting.TabIndex = 0;
            this.buttonsetting.Text = "SETTING";
            this.buttonsetting.UseVisualStyleBackColor = false;
            // 
            // buttonguide
            // 
            this.buttonguide.BackColor = System.Drawing.Color.Transparent;
            this.buttonguide.FlatAppearance.BorderSize = 0;
            this.buttonguide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonguide.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguide.Location = new System.Drawing.Point(163, 263);
            this.buttonguide.Name = "buttonguide";
            this.buttonguide.Size = new System.Drawing.Size(148, 55);
            this.buttonguide.TabIndex = 0;
            this.buttonguide.Text = "GUIDE";
            this.buttonguide.UseVisualStyleBackColor = false;
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Transparent;
            this.buttonexit.FlatAppearance.BorderSize = 0;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(133, 342);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(190, 47);
            this.buttonexit.TabIndex = 0;
            this.buttonexit.Text = "EXIT GAME";
            this.buttonexit.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAROGAME.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 476);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonguide);
            this.Controls.Add(this.buttonsetting);
            this.Controls.Add(this.buttonstart);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonsetting;
        private System.Windows.Forms.Button buttonguide;
        private System.Windows.Forms.Button buttonexit;
    }
}