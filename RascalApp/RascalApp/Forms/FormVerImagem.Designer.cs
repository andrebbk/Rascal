namespace RascalApp.Forms
{
    partial class FormVerImagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerImagem));
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxApagarPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxImagemX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApagarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackgroundImage = global::RascalApp.Properties.Resources.close;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExit.Location = new System.Drawing.Point(1882, 12);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxLeftArrow
            // 
            this.pictureBoxLeftArrow.BackgroundImage = global::RascalApp.Properties.Resources.left_arrow;
            this.pictureBoxLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeftArrow.Location = new System.Drawing.Point(12, 602);
            this.pictureBoxLeftArrow.Name = "pictureBoxLeftArrow";
            this.pictureBoxLeftArrow.Size = new System.Drawing.Size(52, 81);
            this.pictureBoxLeftArrow.TabIndex = 1;
            this.pictureBoxLeftArrow.TabStop = false;
            this.pictureBoxLeftArrow.Click += new System.EventHandler(this.pictureBoxLeftArrow_Click);
            // 
            // pictureBoxRightArrow
            // 
            this.pictureBoxRightArrow.BackgroundImage = global::RascalApp.Properties.Resources.right_arrow;
            this.pictureBoxRightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRightArrow.Location = new System.Drawing.Point(1856, 602);
            this.pictureBoxRightArrow.Name = "pictureBoxRightArrow";
            this.pictureBoxRightArrow.Size = new System.Drawing.Size(52, 81);
            this.pictureBoxRightArrow.TabIndex = 2;
            this.pictureBoxRightArrow.TabStop = false;
            this.pictureBoxRightArrow.Click += new System.EventHandler(this.pictureBoxRightArrow_Click);
            // 
            // pictureBoxApagarPic
            // 
            this.pictureBoxApagarPic.BackgroundImage = global::RascalApp.Properties.Resources.full_trash_container;
            this.pictureBoxApagarPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxApagarPic.Location = new System.Drawing.Point(1882, 60);
            this.pictureBoxApagarPic.Name = "pictureBoxApagarPic";
            this.pictureBoxApagarPic.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxApagarPic.TabIndex = 3;
            this.pictureBoxApagarPic.TabStop = false;
            this.pictureBoxApagarPic.Click += new System.EventHandler(this.pictureBoxApagarPic_Click);
            // 
            // pictureBoxImagemX
            // 
            this.pictureBoxImagemX.Location = new System.Drawing.Point(93, 31);
            this.pictureBoxImagemX.Name = "pictureBoxImagemX";
            this.pictureBoxImagemX.Size = new System.Drawing.Size(1732, 1020);
            this.pictureBoxImagemX.TabIndex = 4;
            this.pictureBoxImagemX.TabStop = false;
            // 
            // FormVerImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxImagemX);
            this.Controls.Add(this.pictureBoxApagarPic);
            this.Controls.Add(this.pictureBoxRightArrow);
            this.Controls.Add(this.pictureBoxLeftArrow);
            this.Controls.Add(this.pictureBoxExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVerImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rascal";
            this.Load += new System.EventHandler(this.FormVerImagem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVerImagem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApagarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxLeftArrow;
        private System.Windows.Forms.PictureBox pictureBoxRightArrow;
        private System.Windows.Forms.PictureBox pictureBoxApagarPic;
        private System.Windows.Forms.PictureBox pictureBoxImagemX;
    }
}