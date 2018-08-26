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
            this.pictureBoxButtonResetErmos = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelContadorErmos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddErmo = new System.Windows.Forms.PictureBox();
            this.listViewErmos = new System.Windows.Forms.ListView();
            this.colummImagens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonResetErmos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddErmo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxButtonResetErmos
            // 
            this.pictureBoxButtonResetErmos.BackgroundImage = global::RascalApp.Properties.Resources.red_restart_icon;
            this.pictureBoxButtonResetErmos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonResetErmos.Location = new System.Drawing.Point(206, 5);
            this.pictureBoxButtonResetErmos.Name = "pictureBoxButtonResetErmos";
            this.pictureBoxButtonResetErmos.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxButtonResetErmos.TabIndex = 31;
            this.pictureBoxButtonResetErmos.TabStop = false;
            this.pictureBoxButtonResetErmos.Click += new System.EventHandler(this.pictureBoxButtonResetErmos_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RascalApp.Properties.Resources.bricks_brickwork;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelContadorErmos);
            this.panel2.Location = new System.Drawing.Point(1493, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 36);
            this.panel2.TabIndex = 30;
            // 
            // labelContadorErmos
            // 
            this.labelContadorErmos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContadorErmos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelContadorErmos.Location = new System.Drawing.Point(-5, 7);
            this.labelContadorErmos.Name = "labelContadorErmos";
            this.labelContadorErmos.Size = new System.Drawing.Size(131, 22);
            this.labelContadorErmos.TabIndex = 21;
            this.labelContadorErmos.Text = "32535";
            this.labelContadorErmos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // listViewErmos
            // 
            this.listViewErmos.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.listViewErmos.BackgroundImageTiled = true;
            this.listViewErmos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewErmos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummImagens});
            this.listViewErmos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewErmos.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewErmos.Location = new System.Drawing.Point(7, 68);
            this.listViewErmos.Name = "listViewErmos";
            this.listViewErmos.Size = new System.Drawing.Size(1608, 910);
            this.listViewErmos.TabIndex = 26;
            this.listViewErmos.UseCompatibleStateImageBehavior = false;
            this.listViewErmos.DoubleClick += new System.EventHandler(this.listViewErmos_DoubleClick);
            // 
            // UserControlErmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBoxButtonResetErmos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxAddErmo);
            this.Controls.Add(this.listViewErmos);
            this.Name = "UserControlErmos";
            this.Size = new System.Drawing.Size(1614, 987);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonResetErmos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddErmo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxAddErmo;
        private System.Windows.Forms.ListView listViewErmos;
        private System.Windows.Forms.ColumnHeader colummImagens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelContadorErmos;
        private System.Windows.Forms.PictureBox pictureBoxButtonResetErmos;
    }
}
