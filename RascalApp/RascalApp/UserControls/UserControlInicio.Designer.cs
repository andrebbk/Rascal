namespace RascalApp.UserControls
{
    partial class UserControlInicio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsfafas = new System.Windows.Forms.Label();
            this.labelsfasfa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDiscoNome = new System.Windows.Forms.Label();
            this.labelDiscoDiretorio = new System.Windows.Forms.Label();
            this.labelDiscoTipo = new System.Windows.Forms.Label();
            this.labelDiscoETotal = new System.Windows.Forms.Label();
            this.labelDiscoELivre = new System.Windows.Forms.Label();
            this.labelDiscoEOcupado = new System.Windows.Forms.Label();
            this.labelFreePercent = new System.Windows.Forms.Label();
            this.labelUsedPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.RascalLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panel1.Controls.Add(this.labelUsedPercent);
            this.panel1.Controls.Add(this.labelFreePercent);
            this.panel1.Controls.Add(this.labelDiscoEOcupado);
            this.panel1.Controls.Add(this.labelDiscoELivre);
            this.panel1.Controls.Add(this.labelDiscoETotal);
            this.panel1.Controls.Add(this.labelDiscoTipo);
            this.panel1.Controls.Add(this.labelDiscoDiretorio);
            this.panel1.Controls.Add(this.labelDiscoNome);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelsfasfa);
            this.panel1.Controls.Add(this.labelsfafas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1507, 194);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conectividade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(159, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(627, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Espaço Total:";
            // 
            // labelsfafas
            // 
            this.labelsfafas.AutoSize = true;
            this.labelsfafas.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsfafas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelsfafas.Location = new System.Drawing.Point(1082, 67);
            this.labelsfafas.Name = "labelsfafas";
            this.labelsfafas.Size = new System.Drawing.Size(155, 25);
            this.labelsfafas.TabIndex = 3;
            this.labelsfafas.Text = "Espaço Livre:";
            // 
            // labelsfasfa
            // 
            this.labelsfasfa.AutoSize = true;
            this.labelsfasfa.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsfasfa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelsfasfa.Location = new System.Drawing.Point(1082, 120);
            this.labelsfasfa.Name = "labelsfasfa";
            this.labelsfasfa.Size = new System.Drawing.Size(196, 25);
            this.labelsfasfa.TabIndex = 4;
            this.labelsfasfa.Text = "Espaço Ocupado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(159, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Diretório:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(627, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo:";
            // 
            // labelDiscoNome
            // 
            this.labelDiscoNome.AutoSize = true;
            this.labelDiscoNome.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoNome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDiscoNome.Location = new System.Drawing.Point(280, 67);
            this.labelDiscoNome.Name = "labelDiscoNome";
            this.labelDiscoNome.Size = new System.Drawing.Size(161, 25);
            this.labelDiscoNome.TabIndex = 7;
            this.labelDiscoNome.Text = "External Insys";
            // 
            // labelDiscoDiretorio
            // 
            this.labelDiscoDiretorio.AutoSize = true;
            this.labelDiscoDiretorio.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoDiretorio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDiscoDiretorio.Location = new System.Drawing.Point(280, 120);
            this.labelDiscoDiretorio.Name = "labelDiscoDiretorio";
            this.labelDiscoDiretorio.Size = new System.Drawing.Size(26, 25);
            this.labelDiscoDiretorio.TabIndex = 8;
            this.labelDiscoDiretorio.Text = "A";
            // 
            // labelDiscoTipo
            // 
            this.labelDiscoTipo.AutoSize = true;
            this.labelDiscoTipo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDiscoTipo.Location = new System.Drawing.Point(800, 67);
            this.labelDiscoTipo.Name = "labelDiscoTipo";
            this.labelDiscoTipo.Size = new System.Drawing.Size(67, 25);
            this.labelDiscoTipo.TabIndex = 9;
            this.labelDiscoTipo.Text = "NTFS";
            // 
            // labelDiscoETotal
            // 
            this.labelDiscoETotal.AutoSize = true;
            this.labelDiscoETotal.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoETotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDiscoETotal.Location = new System.Drawing.Point(800, 120);
            this.labelDiscoETotal.Name = "labelDiscoETotal";
            this.labelDiscoETotal.Size = new System.Drawing.Size(75, 25);
            this.labelDiscoETotal.TabIndex = 10;
            this.labelDiscoETotal.Text = "14 GB";
            // 
            // labelDiscoELivre
            // 
            this.labelDiscoELivre.AutoSize = true;
            this.labelDiscoELivre.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoELivre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDiscoELivre.Location = new System.Drawing.Point(1300, 67);
            this.labelDiscoELivre.Name = "labelDiscoELivre";
            this.labelDiscoELivre.Size = new System.Drawing.Size(75, 25);
            this.labelDiscoELivre.TabIndex = 11;
            this.labelDiscoELivre.Text = "14 GB";
            // 
            // labelDiscoEOcupado
            // 
            this.labelDiscoEOcupado.AutoSize = true;
            this.labelDiscoEOcupado.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoEOcupado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDiscoEOcupado.Location = new System.Drawing.Point(1300, 120);
            this.labelDiscoEOcupado.Name = "labelDiscoEOcupado";
            this.labelDiscoEOcupado.Size = new System.Drawing.Size(75, 25);
            this.labelDiscoEOcupado.TabIndex = 12;
            this.labelDiscoEOcupado.Text = "14 GB";
            // 
            // labelFreePercent
            // 
            this.labelFreePercent.AutoSize = true;
            this.labelFreePercent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreePercent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFreePercent.Location = new System.Drawing.Point(1392, 91);
            this.labelFreePercent.Name = "labelFreePercent";
            this.labelFreePercent.Size = new System.Drawing.Size(37, 16);
            this.labelFreePercent.TabIndex = 13;
            this.labelFreePercent.Text = "70%";
            // 
            // labelUsedPercent
            // 
            this.labelUsedPercent.AutoSize = true;
            this.labelUsedPercent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsedPercent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsedPercent.Location = new System.Drawing.Point(1392, 144);
            this.labelUsedPercent.Name = "labelUsedPercent";
            this.labelUsedPercent.Size = new System.Drawing.Size(37, 16);
            this.labelUsedPercent.TabIndex = 14;
            this.labelUsedPercent.Text = "70%";
            // 
            // UserControlInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlInicio";
            this.Size = new System.Drawing.Size(1614, 987);
            this.Load += new System.EventHandler(this.UserControlInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelsfasfa;
        private System.Windows.Forms.Label labelsfafas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDiscoNome;
        private System.Windows.Forms.Label labelDiscoETotal;
        private System.Windows.Forms.Label labelDiscoTipo;
        private System.Windows.Forms.Label labelDiscoDiretorio;
        private System.Windows.Forms.Label labelDiscoELivre;
        private System.Windows.Forms.Label labelDiscoEOcupado;
        private System.Windows.Forms.Label labelUsedPercent;
        private System.Windows.Forms.Label labelFreePercent;
    }
}
