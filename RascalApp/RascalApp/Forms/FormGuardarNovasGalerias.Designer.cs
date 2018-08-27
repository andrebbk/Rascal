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
            this.labelNomeA = new System.Windows.Forms.Label();
            this.textBoxGalNovoNome = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelCOntador = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
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
            // labelNomeA
            // 
            this.labelNomeA.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeA.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelNomeA.Location = new System.Drawing.Point(151, 146);
            this.labelNomeA.Name = "labelNomeA";
            this.labelNomeA.Size = new System.Drawing.Size(509, 43);
            this.labelNomeA.TabIndex = 1;
            this.labelNomeA.Text = "label1";
            this.labelNomeA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardar.Location = new System.Drawing.Point(51, 304);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(301, 78);
            this.buttonGuardar.TabIndex = 35;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // labelCOntador
            // 
            this.labelCOntador.AutoSize = true;
            this.labelCOntador.BackColor = System.Drawing.Color.Transparent;
            this.labelCOntador.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOntador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCOntador.Location = new System.Drawing.Point(665, 21);
            this.labelCOntador.Name = "labelCOntador";
            this.labelCOntador.Size = new System.Drawing.Size(112, 38);
            this.labelCOntador.TabIndex = 36;
            this.labelCOntador.Text = "29/30";
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSair.Location = new System.Drawing.Point(451, 304);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(301, 78);
            this.buttonSair.TabIndex = 37;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // FormGuardarNovasGalerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.wallpaper2you;
            this.ClientSize = new System.Drawing.Size(798, 415);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelCOntador);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxGalNovoNome);
            this.Controls.Add(this.labelNomeA);
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
        private System.Windows.Forms.Label labelNomeA;
        private System.Windows.Forms.TextBox textBoxGalNovoNome;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelCOntador;
        private System.Windows.Forms.Button buttonSair;
    }
}