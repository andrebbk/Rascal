namespace RascalApp.UserControls
{
    partial class UserControlDesconhecidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddAnonima = new System.Windows.Forms.PictureBox();
            this.listViewDesconhecidas = new System.Windows.Forms.ListView();
            this.colummImagens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddAnonima)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RascalApp.Properties.Resources.bricks_brickwork;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1493, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 36);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(-5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "32535";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.DesconhecidasLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(37, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 54);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxAddAnonima
            // 
            this.pictureBoxAddAnonima.BackgroundImage = global::RascalApp.Properties.Resources.if_HP_Pictures_Folder_Dock_512_17259;
            this.pictureBoxAddAnonima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAddAnonima.Location = new System.Drawing.Point(1446, 26);
            this.pictureBoxAddAnonima.Name = "pictureBoxAddAnonima";
            this.pictureBoxAddAnonima.Size = new System.Drawing.Size(39, 36);
            this.pictureBoxAddAnonima.TabIndex = 28;
            this.pictureBoxAddAnonima.TabStop = false;
            this.pictureBoxAddAnonima.Click += new System.EventHandler(this.pictureBoxAddAnonima_Click);
            // 
            // listViewDesconhecidas
            // 
            this.listViewDesconhecidas.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.listViewDesconhecidas.BackgroundImageTiled = true;
            this.listViewDesconhecidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDesconhecidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummImagens});
            this.listViewDesconhecidas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDesconhecidas.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewDesconhecidas.Location = new System.Drawing.Point(8, 68);
            this.listViewDesconhecidas.Name = "listViewDesconhecidas";
            this.listViewDesconhecidas.Size = new System.Drawing.Size(1608, 910);
            this.listViewDesconhecidas.TabIndex = 26;
            this.listViewDesconhecidas.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlDesconhecidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxAddAnonima);
            this.Controls.Add(this.listViewDesconhecidas);
            this.Name = "UserControlDesconhecidos";
            this.Size = new System.Drawing.Size(1616, 987);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddAnonima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxAddAnonima;
        private System.Windows.Forms.ListView listViewDesconhecidas;
        private System.Windows.Forms.ColumnHeader colummImagens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
