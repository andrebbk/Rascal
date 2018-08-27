namespace RascalApp.Forms
{
    partial class FormEditarModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarModelo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxModeloPic = new System.Windows.Forms.PictureBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNovoNome = new System.Windows.Forms.TextBox();
            this.listBoxGalerias = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNNomeGal = new System.Windows.Forms.TextBox();
            this.buttonOKNome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModeloPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RascalApp.Properties.Resources.EditarModelo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 57);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxModeloPic
            // 
            this.pictureBoxModeloPic.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxModeloPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxModeloPic.Location = new System.Drawing.Point(456, 30);
            this.pictureBoxModeloPic.Name = "pictureBoxModeloPic";
            this.pictureBoxModeloPic.Size = new System.Drawing.Size(483, 490);
            this.pictureBoxModeloPic.TabIndex = 33;
            this.pictureBoxModeloPic.TabStop = false;
            this.pictureBoxModeloPic.Click += new System.EventHandler(this.pictureBoxModeloPic_Click);
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
            this.buttonSair.Location = new System.Drawing.Point(691, 566);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(248, 49);
            this.buttonSair.TabIndex = 32;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApagar.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.buttonApagar.FlatAppearance.BorderSize = 0;
            this.buttonApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagar.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagar.Location = new System.Drawing.Point(386, 566);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(248, 49);
            this.buttonApagar.TabIndex = 31;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditar.Location = new System.Drawing.Point(79, 566);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(248, 49);
            this.buttonEditar.TabIndex = 30;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(59, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome:";
            // 
            // textBoxNovoNome
            // 
            this.textBoxNovoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNovoNome.Location = new System.Drawing.Point(62, 143);
            this.textBoxNovoNome.Name = "textBoxNovoNome";
            this.textBoxNovoNome.Size = new System.Drawing.Size(299, 29);
            this.textBoxNovoNome.TabIndex = 28;
            // 
            // listBoxGalerias
            // 
            this.listBoxGalerias.FormattingEnabled = true;
            this.listBoxGalerias.Location = new System.Drawing.Point(62, 214);
            this.listBoxGalerias.Name = "listBoxGalerias";
            this.listBoxGalerias.Size = new System.Drawing.Size(299, 238);
            this.listBoxGalerias.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(59, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Galerias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(59, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nova designação:";
            // 
            // textBoxNNomeGal
            // 
            this.textBoxNNomeGal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNNomeGal.Location = new System.Drawing.Point(62, 491);
            this.textBoxNNomeGal.Name = "textBoxNNomeGal";
            this.textBoxNNomeGal.Size = new System.Drawing.Size(299, 29);
            this.textBoxNNomeGal.TabIndex = 37;
            // 
            // buttonOKNome
            // 
            this.buttonOKNome.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonOKNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOKNome.FlatAppearance.BorderSize = 0;
            this.buttonOKNome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonOKNome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonOKNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOKNome.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOKNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOKNome.Location = new System.Drawing.Point(367, 491);
            this.buttonOKNome.Name = "buttonOKNome";
            this.buttonOKNome.Size = new System.Drawing.Size(46, 31);
            this.buttonOKNome.TabIndex = 39;
            this.buttonOKNome.Text = "OK";
            this.buttonOKNome.UseVisualStyleBackColor = true;
            this.buttonOKNome.Click += new System.EventHandler(this.buttonOKNome_Click);
            // 
            // FormEditarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.wallpaper2you;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 639);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOKNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNNomeGal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGalerias);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxModeloPic);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNovoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditarModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rascal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModeloPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxModeloPic;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNovoNome;
        private System.Windows.Forms.ListBox listBoxGalerias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNNomeGal;
        private System.Windows.Forms.Button buttonOKNome;
    }
}