namespace RascalApp.UserControls
{
    partial class UserControlGaleria
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelContadorModelos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewGaleria = new System.Windows.Forms.ListView();
            this.colummImagens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RascalApp.Properties.Resources.bricks_brickwork;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelContadorModelos);
            this.panel2.Location = new System.Drawing.Point(1491, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 36);
            this.panel2.TabIndex = 33;
            // 
            // labelContadorModelos
            // 
            this.labelContadorModelos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContadorModelos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelContadorModelos.Location = new System.Drawing.Point(-5, 7);
            this.labelContadorModelos.Name = "labelContadorModelos";
            this.labelContadorModelos.Size = new System.Drawing.Size(131, 22);
            this.labelContadorModelos.TabIndex = 21;
            this.labelContadorModelos.Text = "32535";
            this.labelContadorModelos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.Galeria;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(38, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 60);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // listViewGaleria
            // 
            this.listViewGaleria.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.listViewGaleria.BackgroundImageTiled = true;
            this.listViewGaleria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewGaleria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummImagens});
            this.listViewGaleria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGaleria.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewGaleria.Location = new System.Drawing.Point(9, 69);
            this.listViewGaleria.Name = "listViewGaleria";
            this.listViewGaleria.Size = new System.Drawing.Size(1608, 910);
            this.listViewGaleria.TabIndex = 31;
            this.listViewGaleria.UseCompatibleStateImageBehavior = false;
            this.listViewGaleria.DoubleClick += new System.EventHandler(this.listViewGaleria_DoubleClick);
            // 
            // UserControlGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewGaleria);
            this.Name = "UserControlGaleria";
            this.Size = new System.Drawing.Size(1614, 987);
            this.Load += new System.EventHandler(this.UserControlGaleria_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewGaleria;
        private System.Windows.Forms.ColumnHeader colummImagens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelContadorModelos;
    }
}
