namespace RascalApp
{
    partial class FormSeguranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguranca));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxButtonQuit = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.RascaLIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(191, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(118, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rascal";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(163, 401);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(210, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(155, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introduza o seu PIN NUMBER para prosseguir";
            // 
            // pictureBoxButtonQuit
            // 
            this.pictureBoxButtonQuit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonQuit.BackgroundImage = global::RascalApp.Properties.Resources.letter_x_icon;
            this.pictureBoxButtonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonQuit.Location = new System.Drawing.Point(486, 0);
            this.pictureBoxButtonQuit.Name = "pictureBoxButtonQuit";
            this.pictureBoxButtonQuit.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxButtonQuit.TabIndex = 3;
            this.pictureBoxButtonQuit.TabStop = false;
            this.pictureBoxButtonQuit.Click += new System.EventHandler(this.pictureBoxButtonQuit_Click);
            // 
            // pictureBoxButtonMinimize
            // 
            this.pictureBoxButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonMinimize.BackgroundImage = global::RascalApp.Properties.Resources.minimize_icon;
            this.pictureBoxButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonMinimize.Location = new System.Drawing.Point(449, 8);
            this.pictureBoxButtonMinimize.Name = "pictureBoxButtonMinimize";
            this.pictureBoxButtonMinimize.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxButtonMinimize.TabIndex = 4;
            this.pictureBoxButtonMinimize.TabStop = false;
            this.pictureBoxButtonMinimize.Click += new System.EventHandler(this.pictureBoxButtonMinimize_Click);
            // 
            // FormSeguranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.bricks_brickwork;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 508);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxButtonMinimize);
            this.Controls.Add(this.pictureBoxButtonQuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSeguranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rascal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxButtonQuit;
        private System.Windows.Forms.PictureBox pictureBoxButtonMinimize;
    }
}

