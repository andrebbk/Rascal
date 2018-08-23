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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxNovaFotoModelo = new System.Windows.Forms.PictureBox();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovaFotoModelo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(173, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 38);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(71, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 116);
            this.label1.TabIndex = 12;
            this.label1.Text = "Novo Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(167, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // pictureBoxNovaFotoModelo
            // 
            this.pictureBoxNovaFotoModelo.BackgroundImage = global::RascalApp.Properties.Resources.portret;
            this.pictureBoxNovaFotoModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNovaFotoModelo.Location = new System.Drawing.Point(800, 58);
            this.pictureBoxNovaFotoModelo.Name = "pictureBoxNovaFotoModelo";
            this.pictureBoxNovaFotoModelo.Size = new System.Drawing.Size(728, 624);
            this.pictureBoxNovaFotoModelo.TabIndex = 14;
            this.pictureBoxNovaFotoModelo.TabStop = false;
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackgroundImage = global::RascalApp.Properties.Resources.backImage;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInicio.Location = new System.Drawing.Point(173, 518);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(507, 153);
            this.buttonInicio.TabIndex = 10;
            this.buttonInicio.Text = "Guardar";
            this.buttonInicio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBoxNovaFotoModelo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonInicio);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(30, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 769);
            this.panel1.TabIndex = 15;
            // 
            // UserControlNovoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlNovoModelo";
            this.Size = new System.Drawing.Size(1614, 987);
            this.Load += new System.EventHandler(this.UserControlNovoModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovaFotoModelo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxNovaFotoModelo;
        private System.Windows.Forms.Panel panel1;
    }
}
