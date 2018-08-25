﻿namespace RascalApp.UserControls
{
    partial class UserControlNovoModelo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxNovaFotoModelo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.textBoxNovoNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovaFotoModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBoxNovoNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxNovaFotoModelo);
            this.panel1.Controls.Add(this.buttonRegistar);
            this.panel1.Location = new System.Drawing.Point(30, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 769);
            this.panel1.TabIndex = 15;
            // 
            // pictureBoxNovaFotoModelo
            // 
            this.pictureBoxNovaFotoModelo.BackgroundImage = global::RascalApp.Properties.Resources.portret;
            this.pictureBoxNovaFotoModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNovaFotoModelo.Location = new System.Drawing.Point(779, 19);
            this.pictureBoxNovaFotoModelo.Name = "pictureBoxNovaFotoModelo";
            this.pictureBoxNovaFotoModelo.Size = new System.Drawing.Size(670, 559);
            this.pictureBoxNovaFotoModelo.TabIndex = 14;
            this.pictureBoxNovaFotoModelo.TabStop = false;
            this.pictureBoxNovaFotoModelo.Click += new System.EventHandler(this.pictureBoxNovaFotoModelo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(101, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonRegistar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegistar.FlatAppearance.BorderSize = 0;
            this.buttonRegistar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonRegistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistar.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistar.Location = new System.Drawing.Point(313, 629);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(899, 79);
            this.buttonRegistar.TabIndex = 10;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // textBoxNovoNome
            // 
            this.textBoxNovoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNovoNome.Location = new System.Drawing.Point(107, 290);
            this.textBoxNovoNome.Name = "textBoxNovoNome";
            this.textBoxNovoNome.Size = new System.Drawing.Size(480, 38);
            this.textBoxNovoNome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.NovoModeloLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(72, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 112);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlNovoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlNovoModelo";
            this.Size = new System.Drawing.Size(1614, 987);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovaFotoModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.TextBox textBoxNovoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxNovaFotoModelo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
