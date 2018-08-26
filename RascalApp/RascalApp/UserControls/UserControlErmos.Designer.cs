namespace RascalApp.UserControls
{
    partial class UserControlErmos
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
            this.pictureBoxAddErmo = new System.Windows.Forms.PictureBox();
            this.listViewOutras = new System.Windows.Forms.ListView();
            this.colummImagens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelContadorOutras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddErmo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.ErmosLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 54);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxAddErmo
            // 
            this.pictureBoxAddErmo.BackgroundImage = global::RascalApp.Properties.Resources.if_HP_Pictures_Folder_Dock_512_17259;
            this.pictureBoxAddErmo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAddErmo.Location = new System.Drawing.Point(1445, 26);
            this.pictureBoxAddErmo.Name = "pictureBoxAddErmo";
            this.pictureBoxAddErmo.Size = new System.Drawing.Size(39, 36);
            this.pictureBoxAddErmo.TabIndex = 28;
            this.pictureBoxAddErmo.TabStop = false;
            this.pictureBoxAddErmo.Click += new System.EventHandler(this.pictureBoxAddErmo_Click);
            // 
            // listViewOutras
            // 
            this.listViewOutras.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.listViewOutras.BackgroundImageTiled = true;
            this.listViewOutras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewOutras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummImagens});
            this.listViewOutras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOutras.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewOutras.Location = new System.Drawing.Point(7, 68);
            this.listViewOutras.Name = "listViewOutras";
            this.listViewOutras.Size = new System.Drawing.Size(1608, 910);
            this.listViewOutras.TabIndex = 26;
            this.listViewOutras.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RascalApp.Properties.Resources.bricks_brickwork;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelContadorOutras);
            this.panel2.Location = new System.Drawing.Point(1493, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 36);
            this.panel2.TabIndex = 30;
            // 
            // labelContadorOutras
            // 
            this.labelContadorOutras.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContadorOutras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelContadorOutras.Location = new System.Drawing.Point(-5, 7);
            this.labelContadorOutras.Name = "labelContadorOutras";
            this.labelContadorOutras.Size = new System.Drawing.Size(131, 22);
            this.labelContadorOutras.TabIndex = 21;
            this.labelContadorOutras.Text = "32535";
            this.labelContadorOutras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlErmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxAddErmo);
            this.Controls.Add(this.listViewOutras);
            this.Name = "UserControlErmos";
            this.Size = new System.Drawing.Size(1614, 987);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddErmo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxAddErmo;
        private System.Windows.Forms.ListView listViewOutras;
        private System.Windows.Forms.ColumnHeader colummImagens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelContadorOutras;
    }
}
