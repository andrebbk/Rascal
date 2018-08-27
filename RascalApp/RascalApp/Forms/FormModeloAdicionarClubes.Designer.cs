namespace RascalApp.Forms
{
    partial class FormModeloAdicionarClubes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModeloAdicionarClubes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.listViewClubes = new System.Windows.Forms.ListView();
            this.colummImagens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNClubesSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.ClubesLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 63);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            this.buttonGuardar.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardar.Location = new System.Drawing.Point(393, 423);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(216, 49);
            this.buttonGuardar.TabIndex = 42;
            this.buttonGuardar.Tag = "0";
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
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
            this.buttonSair.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSair.Location = new System.Drawing.Point(615, 423);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(216, 49);
            this.buttonSair.TabIndex = 43;
            this.buttonSair.Tag = "0";
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // listViewClubes
            // 
            this.listViewClubes.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.listViewClubes.BackgroundImageTiled = true;
            this.listViewClubes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewClubes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummImagens});
            this.listViewClubes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClubes.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewClubes.Location = new System.Drawing.Point(12, 72);
            this.listViewClubes.Name = "listViewClubes";
            this.listViewClubes.Size = new System.Drawing.Size(819, 345);
            this.listViewClubes.TabIndex = 44;
            this.listViewClubes.UseCompatibleStateImageBehavior = false;
            // 
            // labelNClubesSelected
            // 
            this.labelNClubesSelected.AutoSize = true;
            this.labelNClubesSelected.BackColor = System.Drawing.Color.Transparent;
            this.labelNClubesSelected.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNClubesSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelNClubesSelected.Location = new System.Drawing.Point(801, 51);
            this.labelNClubesSelected.Name = "labelNClubesSelected";
            this.labelNClubesSelected.Size = new System.Drawing.Size(30, 18);
            this.labelNClubesSelected.TabIndex = 45;
            this.labelNClubesSelected.Text = "12";
            // 
            // FormModeloAdicionarClubes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.wallpaper2you;
            this.ClientSize = new System.Drawing.Size(847, 484);
            this.ControlBox = false;
            this.Controls.Add(this.labelNClubesSelected);
            this.Controls.Add(this.listViewClubes);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModeloAdicionarClubes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rascal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ListView listViewClubes;
        private System.Windows.Forms.ColumnHeader colummImagens;
        private System.Windows.Forms.Label labelNClubesSelected;
    }
}