namespace RascalApp.UserControls
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
            this.textBoxNovoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxNovaFotoModelo = new System.Windows.Forms.PictureBox();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovaFotoModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(30, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 769);
            this.panel1.TabIndex = 15;
            // 
            // textBoxNovoNome
            // 
            this.textBoxNovoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNovoNome.Location = new System.Drawing.Point(111, 365);
            this.textBoxNovoNome.Name = "textBoxNovoNome";
            this.textBoxNovoNome.Size = new System.Drawing.Size(480, 38);
            this.textBoxNovoNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(105, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // pictureBoxNovaFotoModelo
            // 
            this.pictureBoxNovaFotoModelo.BackgroundImage = global::RascalApp.Properties.Resources.portret;
            this.pictureBoxNovaFotoModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNovaFotoModelo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxNovaFotoModelo.Name = "pictureBoxNovaFotoModelo";
            this.pictureBoxNovaFotoModelo.Size = new System.Drawing.Size(752, 626);
            this.pictureBoxNovaFotoModelo.TabIndex = 14;
            this.pictureBoxNovaFotoModelo.TabStop = false;
            this.pictureBoxNovaFotoModelo.Click += new System.EventHandler(this.pictureBoxNovaFotoModelo_Click);
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
            this.buttonRegistar.Location = new System.Drawing.Point(111, 456);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(480, 92);
            this.buttonRegistar.TabIndex = 10;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.NovoModeloLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(111, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 123);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panel2.Controls.Add(this.pictureBoxNovaFotoModelo);
            this.panel2.Location = new System.Drawing.Point(794, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 632);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.buttonRegistar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxNovoNome);
            this.panel3.Location = new System.Drawing.Point(20, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 632);
            this.panel3.TabIndex = 16;
            // 
            // UserControlNovoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlNovoModelo";
            this.Size = new System.Drawing.Size(1614, 987);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovaFotoModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.TextBox textBoxNovoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxNovaFotoModelo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
