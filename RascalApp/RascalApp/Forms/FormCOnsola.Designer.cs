namespace RascalApp.Forms
{
    partial class FormCOnsola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCOnsola));
            this.buttonSair = new System.Windows.Forms.Button();
            this.listBoxConsole = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.buttonSair.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSair.Location = new System.Drawing.Point(559, 460);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(198, 57);
            this.buttonSair.TabIndex = 38;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // listBoxConsole
            // 
            this.listBoxConsole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBoxConsole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxConsole.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxConsole.ForeColor = System.Drawing.Color.IndianRed;
            this.listBoxConsole.FormattingEnabled = true;
            this.listBoxConsole.ItemHeight = 30;
            this.listBoxConsole.Location = new System.Drawing.Point(12, 14);
            this.listBoxConsole.Name = "listBoxConsole";
            this.listBoxConsole.Size = new System.Drawing.Size(745, 424);
            this.listBoxConsole.TabIndex = 39;
            this.listBoxConsole.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxConsole_DrawItem);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.RascalConsole;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 467);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 50);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // FormCOnsola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.wallpaper2you;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 529);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxConsole);
            this.Controls.Add(this.buttonSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCOnsola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rascal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ListBox listBoxConsole;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}