namespace RascalApp.Forms
{
    partial class FormAdicionarOutras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarOutras));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewNovasOutras = new System.Windows.Forms.ListView();
            this.colummImagens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCarregarFotos = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.AddOutrasLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // listViewNovasOutras
            // 
            this.listViewNovasOutras.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.listViewNovasOutras.BackgroundImageTiled = true;
            this.listViewNovasOutras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewNovasOutras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummImagens});
            this.listViewNovasOutras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNovasOutras.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewNovasOutras.Location = new System.Drawing.Point(12, 68);
            this.listViewNovasOutras.Name = "listViewNovasOutras";
            this.listViewNovasOutras.Size = new System.Drawing.Size(1229, 527);
            this.listViewNovasOutras.TabIndex = 27;
            this.listViewNovasOutras.UseCompatibleStateImageBehavior = false;
            // 
            // buttonCarregarFotos
            // 
            this.buttonCarregarFotos.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonCarregarFotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCarregarFotos.FlatAppearance.BorderSize = 0;
            this.buttonCarregarFotos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonCarregarFotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCarregarFotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCarregarFotos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarregarFotos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCarregarFotos.Location = new System.Drawing.Point(515, 610);
            this.buttonCarregarFotos.Name = "buttonCarregarFotos";
            this.buttonCarregarFotos.Size = new System.Drawing.Size(238, 49);
            this.buttonCarregarFotos.TabIndex = 28;
            this.buttonCarregarFotos.Text = "Carregar Fotos";
            this.buttonCarregarFotos.UseVisualStyleBackColor = true;
            this.buttonCarregarFotos.Click += new System.EventHandler(this.buttonCarregarFotos_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardar.Location = new System.Drawing.Point(759, 610);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(238, 49);
            this.buttonGuardar.TabIndex = 29;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
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
            this.buttonSair.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSair.Location = new System.Drawing.Point(1003, 610);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(238, 49);
            this.buttonSair.TabIndex = 30;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarOutras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.wallpaper2you;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 665);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCarregarFotos);
            this.Controls.Add(this.listViewNovasOutras);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdicionarOutras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rascal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewNovasOutras;
        private System.Windows.Forms.ColumnHeader colummImagens;
        private System.Windows.Forms.Button buttonCarregarFotos;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonSair;
    }
}