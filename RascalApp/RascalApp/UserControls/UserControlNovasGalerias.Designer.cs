﻿namespace RascalApp.UserControls
{
    partial class UserControlNovasGalerias
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
            this.pictureBoxOldMethod = new System.Windows.Forms.PictureBox();
            this.panelShowDirectory = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCaminho = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.listViewNovasGalerias = new System.Windows.Forms.ListView();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonSelectFold = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOldMethod)).BeginInit();
            this.panelShowDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOldMethod
            // 
            this.pictureBoxOldMethod.BackgroundImage = global::RascalApp.Properties.Resources.file_manage;
            this.pictureBoxOldMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOldMethod.Location = new System.Drawing.Point(1531, 86);
            this.pictureBoxOldMethod.Name = "pictureBoxOldMethod";
            this.pictureBoxOldMethod.Size = new System.Drawing.Size(37, 41);
            this.pictureBoxOldMethod.TabIndex = 41;
            this.pictureBoxOldMethod.TabStop = false;
            this.pictureBoxOldMethod.Click += new System.EventHandler(this.pictureBoxOldMethod_Click);
            // 
            // panelShowDirectory
            // 
            this.panelShowDirectory.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.panelShowDirectory.Controls.Add(this.label1);
            this.panelShowDirectory.Controls.Add(this.labelCaminho);
            this.panelShowDirectory.Location = new System.Drawing.Point(45, 854);
            this.panelShowDirectory.Name = "panelShowDirectory";
            this.panelShowDirectory.Size = new System.Drawing.Size(277, 54);
            this.panelShowDirectory.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Diretório:";
            // 
            // labelCaminho
            // 
            this.labelCaminho.AutoSize = true;
            this.labelCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaminho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCaminho.Location = new System.Drawing.Point(9, 31);
            this.labelCaminho.Name = "labelCaminho";
            this.labelCaminho.Size = new System.Drawing.Size(17, 16);
            this.labelCaminho.TabIndex = 38;
            this.labelCaminho.Text = "...";
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
            this.buttonGuardar.Location = new System.Drawing.Point(914, 864);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(312, 82);
            this.buttonGuardar.TabIndex = 39;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // listViewNovasGalerias
            // 
            this.listViewNovasGalerias.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.listViewNovasGalerias.BackgroundImageTiled = true;
            this.listViewNovasGalerias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewNovasGalerias.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNovasGalerias.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewNovasGalerias.Location = new System.Drawing.Point(45, 133);
            this.listViewNovasGalerias.Name = "listViewNovasGalerias";
            this.listViewNovasGalerias.Size = new System.Drawing.Size(1523, 715);
            this.listViewNovasGalerias.TabIndex = 37;
            this.listViewNovasGalerias.UseCompatibleStateImageBehavior = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVoltar.Location = new System.Drawing.Point(1256, 864);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(312, 82);
            this.buttonVoltar.TabIndex = 36;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonSelectFold
            // 
            this.buttonSelectFold.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonSelectFold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectFold.FlatAppearance.BorderSize = 0;
            this.buttonSelectFold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonSelectFold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSelectFold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFold.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectFold.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSelectFold.Location = new System.Drawing.Point(571, 864);
            this.buttonSelectFold.Name = "buttonSelectFold";
            this.buttonSelectFold.Size = new System.Drawing.Size(312, 82);
            this.buttonSelectFold.TabIndex = 34;
            this.buttonSelectFold.Text = "Selecionar";
            this.buttonSelectFold.UseVisualStyleBackColor = true;
            this.buttonSelectFold.Click += new System.EventHandler(this.buttonCarregarFotos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.NovasGaleriaslogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlNovasGalerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBoxOldMethod);
            this.Controls.Add(this.panelShowDirectory);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.listViewNovasGalerias);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonSelectFold);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlNovasGalerias";
            this.Size = new System.Drawing.Size(1614, 987);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOldMethod)).EndInit();
            this.panelShowDirectory.ResumeLayout(false);
            this.panelShowDirectory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSelectFold;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ListView listViewNovasGalerias;
        private System.Windows.Forms.Label labelCaminho;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Panel panelShowDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxOldMethod;
    }
}
