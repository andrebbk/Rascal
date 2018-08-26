namespace RascalApp.Forms
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.pictureBoxButtonMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonQuit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelConsola = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClubes = new System.Windows.Forms.Button();
            this.buttonOutras = new System.Windows.Forms.Button();
            this.buttonErmos = new System.Windows.Forms.Button();
            this.buttonNovoModelo = new System.Windows.Forms.Button();
            this.buttonGaleria = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxButtonMinimize
            // 
            this.pictureBoxButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonMinimize.BackgroundImage = global::RascalApp.Properties.Resources.minimize_icon;
            this.pictureBoxButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonMinimize.Location = new System.Drawing.Point(1544, 11);
            this.pictureBoxButtonMinimize.Name = "pictureBoxButtonMinimize";
            this.pictureBoxButtonMinimize.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxButtonMinimize.TabIndex = 6;
            this.pictureBoxButtonMinimize.TabStop = false;
            this.pictureBoxButtonMinimize.Click += new System.EventHandler(this.pictureBoxButtonMinimize_Click);
            // 
            // pictureBoxButtonQuit
            // 
            this.pictureBoxButtonQuit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonQuit.BackgroundImage = global::RascalApp.Properties.Resources.letter_x_icon;
            this.pictureBoxButtonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonQuit.Location = new System.Drawing.Point(1581, 3);
            this.pictureBoxButtonQuit.Name = "pictureBoxButtonQuit";
            this.pictureBoxButtonQuit.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxButtonQuit.TabIndex = 5;
            this.pictureBoxButtonQuit.TabStop = false;
            this.pictureBoxButtonQuit.Click += new System.EventHandler(this.pictureBoxButtonQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.RascaLIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(127, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rascal";
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.Transparent;
            this.panelSideBar.BackgroundImage = global::RascalApp.Properties.Resources.wallpaper2you;
            this.panelSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelSideBar.Controls.Add(this.label2);
            this.panelSideBar.Controls.Add(this.panel3);
            this.panelSideBar.Controls.Add(this.labelConsola);
            this.panelSideBar.Controls.Add(this.pictureBox2);
            this.panelSideBar.Controls.Add(this.panel1);
            this.panelSideBar.Controls.Add(this.buttonClubes);
            this.panelSideBar.Controls.Add(this.buttonOutras);
            this.panelSideBar.Controls.Add(this.buttonErmos);
            this.panelSideBar.Controls.Add(this.buttonNovoModelo);
            this.panelSideBar.Controls.Add(this.buttonGaleria);
            this.panelSideBar.Controls.Add(this.buttonInicio);
            this.panelSideBar.Controls.Add(this.label1);
            this.panelSideBar.Controls.Add(this.pictureBox1);
            this.panelSideBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideBar.Location = new System.Drawing.Point(0, -4);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(286, 1084);
            this.panelSideBar.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 992);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Output:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panel3.Location = new System.Drawing.Point(0, 971);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 18);
            this.panel3.TabIndex = 16;
            // 
            // labelConsola
            // 
            this.labelConsola.AutoSize = true;
            this.labelConsola.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelConsola.Location = new System.Drawing.Point(3, 1012);
            this.labelConsola.Name = "labelConsola";
            this.labelConsola.Size = new System.Drawing.Size(106, 18);
            this.labelConsola.TabIndex = 17;
            this.labelConsola.Text = "Bem vindo! ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::RascalApp.Properties.Resources.woman_silhueta;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(106, 688);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 270);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 18);
            this.panel1.TabIndex = 15;
            // 
            // buttonClubes
            // 
            this.buttonClubes.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.buttonClubes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClubes.FlatAppearance.BorderSize = 0;
            this.buttonClubes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClubes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClubes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClubes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClubes.Location = new System.Drawing.Point(3, 598);
            this.buttonClubes.Name = "buttonClubes";
            this.buttonClubes.Size = new System.Drawing.Size(280, 73);
            this.buttonClubes.TabIndex = 14;
            this.buttonClubes.Text = "    Clubes";
            this.buttonClubes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClubes.UseVisualStyleBackColor = true;
            this.buttonClubes.Click += new System.EventHandler(this.buttonClubes_Click);
            this.buttonClubes.MouseLeave += new System.EventHandler(this.buttonClubes_MouseLeave);
            this.buttonClubes.MouseHover += new System.EventHandler(this.buttonClubes_MouseHover);
            // 
            // buttonOutras
            // 
            this.buttonOutras.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.buttonOutras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOutras.FlatAppearance.BorderSize = 0;
            this.buttonOutras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonOutras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutras.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOutras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOutras.Location = new System.Drawing.Point(2, 517);
            this.buttonOutras.Name = "buttonOutras";
            this.buttonOutras.Size = new System.Drawing.Size(280, 73);
            this.buttonOutras.TabIndex = 13;
            this.buttonOutras.Text = "    Outras";
            this.buttonOutras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOutras.UseVisualStyleBackColor = true;
            this.buttonOutras.Click += new System.EventHandler(this.buttonOutras_Click);
            this.buttonOutras.MouseLeave += new System.EventHandler(this.buttonOutras_MouseLeave);
            this.buttonOutras.MouseHover += new System.EventHandler(this.buttonOutras_MouseHover);
            // 
            // buttonErmos
            // 
            this.buttonErmos.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.buttonErmos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonErmos.FlatAppearance.BorderSize = 0;
            this.buttonErmos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonErmos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErmos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErmos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonErmos.Location = new System.Drawing.Point(3, 438);
            this.buttonErmos.Name = "buttonErmos";
            this.buttonErmos.Size = new System.Drawing.Size(280, 73);
            this.buttonErmos.TabIndex = 12;
            this.buttonErmos.Text = "    Ermos";
            this.buttonErmos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonErmos.UseVisualStyleBackColor = true;
            this.buttonErmos.Click += new System.EventHandler(this.buttonErmos_Click);
            this.buttonErmos.MouseLeave += new System.EventHandler(this.buttonErmos_MouseLeave);
            this.buttonErmos.MouseHover += new System.EventHandler(this.buttonErmos_MouseHover);
            // 
            // buttonNovoModelo
            // 
            this.buttonNovoModelo.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.buttonNovoModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNovoModelo.FlatAppearance.BorderSize = 0;
            this.buttonNovoModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNovoModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoModelo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoModelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNovoModelo.Location = new System.Drawing.Point(3, 359);
            this.buttonNovoModelo.Name = "buttonNovoModelo";
            this.buttonNovoModelo.Size = new System.Drawing.Size(280, 73);
            this.buttonNovoModelo.TabIndex = 11;
            this.buttonNovoModelo.Text = "    Novo Modelo";
            this.buttonNovoModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovoModelo.UseVisualStyleBackColor = true;
            this.buttonNovoModelo.Click += new System.EventHandler(this.buttonNovoModelo_Click);
            this.buttonNovoModelo.MouseLeave += new System.EventHandler(this.buttonNovoModelo_MouseLeave);
            this.buttonNovoModelo.MouseHover += new System.EventHandler(this.buttonNovoModelo_MouseHover);
            // 
            // buttonGaleria
            // 
            this.buttonGaleria.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.buttonGaleria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGaleria.FlatAppearance.BorderSize = 0;
            this.buttonGaleria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGaleria.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGaleria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGaleria.Location = new System.Drawing.Point(3, 280);
            this.buttonGaleria.Name = "buttonGaleria";
            this.buttonGaleria.Size = new System.Drawing.Size(280, 73);
            this.buttonGaleria.TabIndex = 10;
            this.buttonGaleria.Text = "    Galeria";
            this.buttonGaleria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGaleria.UseVisualStyleBackColor = true;
            this.buttonGaleria.Click += new System.EventHandler(this.buttonGaleria_Click);
            this.buttonGaleria.MouseLeave += new System.EventHandler(this.buttonGaleria_MouseLeave);
            this.buttonGaleria.MouseHover += new System.EventHandler(this.buttonGaleria_MouseHover);
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.buttonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInicio.Location = new System.Drawing.Point(3, 201);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(280, 73);
            this.buttonInicio.TabIndex = 9;
            this.buttonInicio.Text = "    Início";
            this.buttonInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            this.buttonInicio.MouseLeave += new System.EventHandler(this.buttonInicio_MouseLeave);
            this.buttonInicio.MouseHover += new System.EventHandler(this.buttonInicio_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RascalApp.Properties.Resources.wallpaper2you;
            this.panel2.Controls.Add(this.pictureBoxButtonMinimize);
            this.panel2.Controls.Add(this.pictureBoxButtonQuit);
            this.panel2.Location = new System.Drawing.Point(285, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 48);
            this.panel2.TabIndex = 10;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Location = new System.Drawing.Point(294, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1614, 987);
            this.panelContainer.TabIndex = 11;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.bricks_brickwork;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.Text = "Rascal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxButtonMinimize;
        private System.Windows.Forms.PictureBox pictureBoxButtonQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonGaleria;
        private System.Windows.Forms.Button buttonNovoModelo;
        private System.Windows.Forms.Button buttonClubes;
        private System.Windows.Forms.Button buttonOutras;
        private System.Windows.Forms.Button buttonErmos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelConsola;
        private System.Windows.Forms.Label label2;
    }
}