namespace RascalApp.Forms
{
    partial class FormGuardarNovasGalerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuardarNovasGalerias));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGalNovoNome = new System.Windows.Forms.TextBox();
            this.buttonGaurdar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.NovaGal;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBoxGalNovoNome
            // 
            this.textBoxGalNovoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGalNovoNome.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGalNovoNome.Location = new System.Drawing.Point(151, 228);
            this.textBoxGalNovoNome.Name = "textBoxGalNovoNome";
            this.textBoxGalNovoNome.Size = new System.Drawing.Size(509, 40);
            this.textBoxGalNovoNome.TabIndex = 2;
            // 
            // buttonGaurdar
            // 
            this.buttonGaurdar.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonGaurdar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGaurdar.FlatAppearance.BorderSize = 0;
            this.buttonGaurdar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonGaurdar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonGaurdar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGaurdar.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGaurdar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGaurdar.Location = new System.Drawing.Point(56, 296);
            this.buttonGaurdar.Name = "buttonGaurdar";
            this.buttonGaurdar.Size = new System.Drawing.Size(339, 79);
            this.buttonGaurdar.TabIndex = 35;
            this.buttonGaurdar.Text = "Selecionar";
            this.buttonGaurdar.UseVisualStyleBackColor = true;
            // 
            // FormGuardarNovasGalerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.wallpaper2you;
            this.ClientSize = new System.Drawing.Size(798, 415);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGaurdar);
            this.Controls.Add(this.textBoxGalNovoNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGuardarNovasGalerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rascal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGalNovoNome;
        private System.Windows.Forms.Button buttonGaurdar;
    }
}