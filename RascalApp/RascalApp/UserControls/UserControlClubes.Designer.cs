namespace RascalApp.UserControls
{
    partial class UserControlClubes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewClubes_ = new System.Windows.Forms.ListView();
            this.colummImagens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxButtonReset = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxNovaFota = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistarClube = new System.Windows.Forms.Button();
            this.textBoxNovoNome = new System.Windows.Forms.TextBox();
            this.labelContadorClubes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonReset)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovaFota)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(38, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 45);
            this.label3.TabIndex = 17;
            this.label3.Text = "Novo Clube";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(38, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 45);
            this.label4.TabIndex = 18;
            this.label4.Text = "Clubes";
            // 
            // listViewClubes_
            // 
            this.listViewClubes_.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.listViewClubes_.BackgroundImageTiled = true;
            this.listViewClubes_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewClubes_.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummImagens});
            this.listViewClubes_.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClubes_.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewClubes_.Location = new System.Drawing.Point(24, 297);
            this.listViewClubes_.Name = "listViewClubes_";
            this.listViewClubes_.Size = new System.Drawing.Size(1568, 687);
            this.listViewClubes_.TabIndex = 20;
            this.listViewClubes_.UseCompatibleStateImageBehavior = false;
            this.listViewClubes_.DoubleClick += new System.EventHandler(this.listViewClubes__DoubleClick);
            // 
            // pictureBoxButtonReset
            // 
            this.pictureBoxButtonReset.BackgroundImage = global::RascalApp.Properties.Resources.red_restart_icon;
            this.pictureBoxButtonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonReset.Location = new System.Drawing.Point(193, 239);
            this.pictureBoxButtonReset.Name = "pictureBoxButtonReset";
            this.pictureBoxButtonReset.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxButtonReset.TabIndex = 19;
            this.pictureBoxButtonReset.TabStop = false;
            this.pictureBoxButtonReset.Click += new System.EventHandler(this.pictureBoxButtonReset_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxNovaFota);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRegistarClube);
            this.panel1.Controls.Add(this.textBoxNovoNome);
            this.panel1.Location = new System.Drawing.Point(24, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 129);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(962, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Clica para mudar a foto";
            // 
            // pictureBoxNovaFota
            // 
            this.pictureBoxNovaFota.BackgroundImage = global::RascalApp.Properties.Resources.if_HP_Pictures_Folder_Dock_512_17259;
            this.pictureBoxNovaFota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNovaFota.Location = new System.Drawing.Point(725, 21);
            this.pictureBoxNovaFota.Name = "pictureBoxNovaFota";
            this.pictureBoxNovaFota.Size = new System.Drawing.Size(231, 89);
            this.pictureBoxNovaFota.TabIndex = 14;
            this.pictureBoxNovaFota.TabStop = false;
            this.pictureBoxNovaFota.Click += new System.EventHandler(this.pictureBoxNovaFota_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // buttonRegistarClube
            // 
            this.buttonRegistarClube.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonRegistarClube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegistarClube.FlatAppearance.BorderSize = 0;
            this.buttonRegistarClube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonRegistarClube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRegistarClube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistarClube.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistarClube.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistarClube.Location = new System.Drawing.Point(1305, 62);
            this.buttonRegistarClube.Name = "buttonRegistarClube";
            this.buttonRegistarClube.Size = new System.Drawing.Size(238, 49);
            this.buttonRegistarClube.TabIndex = 10;
            this.buttonRegistarClube.Text = "Registar";
            this.buttonRegistarClube.UseVisualStyleBackColor = true;
            this.buttonRegistarClube.Click += new System.EventHandler(this.buttonRegistarClube_Click);
            // 
            // textBoxNovoNome
            // 
            this.textBoxNovoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNovoNome.Location = new System.Drawing.Point(33, 77);
            this.textBoxNovoNome.Name = "textBoxNovoNome";
            this.textBoxNovoNome.Size = new System.Drawing.Size(386, 29);
            this.textBoxNovoNome.TabIndex = 0;
            // 
            // labelContadorClubes
            // 
            this.labelContadorClubes.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContadorClubes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelContadorClubes.Location = new System.Drawing.Point(3, 7);
            this.labelContadorClubes.Name = "labelContadorClubes";
            this.labelContadorClubes.Size = new System.Drawing.Size(205, 36);
            this.labelContadorClubes.TabIndex = 21;
            this.labelContadorClubes.Text = "0 clubes";
            this.labelContadorClubes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RascalApp.Properties.Resources.bricks_brickwork;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelContadorClubes);
            this.panel2.Location = new System.Drawing.Point(1384, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 50);
            this.panel2.TabIndex = 22;
            // 
            // UserControlClubes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewClubes_);
            this.Controls.Add(this.pictureBoxButtonReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlClubes";
            this.Size = new System.Drawing.Size(1614, 987);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonReset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovaFota)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistarClube;
        private System.Windows.Forms.TextBox textBoxNovoNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxNovaFota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxButtonReset;
        private System.Windows.Forms.ListView listViewClubes_;
        private System.Windows.Forms.ColumnHeader colummImagens;
        private System.Windows.Forms.Label labelContadorClubes;
        private System.Windows.Forms.Panel panel2;
    }
}
