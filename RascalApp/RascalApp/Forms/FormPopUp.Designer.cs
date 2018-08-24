namespace RascalApp.Forms
{
    partial class FormPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopUp));
            this.buttonSim = new System.Windows.Forms.Button();
            this.buttonNao = new System.Windows.Forms.Button();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSim
            // 
            this.buttonSim.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSim.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSim.FlatAppearance.BorderSize = 0;
            this.buttonSim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSim.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSim.Location = new System.Drawing.Point(47, 116);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(127, 46);
            this.buttonSim.TabIndex = 11;
            this.buttonSim.Text = "Sim";
            this.buttonSim.UseVisualStyleBackColor = true;
            // 
            // buttonNao
            // 
            this.buttonNao.BackgroundImage = global::RascalApp.Properties.Resources.Wooddownload;
            this.buttonNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonNao.FlatAppearance.BorderSize = 0;
            this.buttonNao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonNao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNao.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNao.Location = new System.Drawing.Point(227, 116);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(127, 46);
            this.buttonNao.TabIndex = 12;
            this.buttonNao.Text = "Não";
            this.buttonNao.UseVisualStyleBackColor = true;
            // 
            // labelMensagem
            // 
            this.labelMensagem.BackColor = System.Drawing.Color.Transparent;
            this.labelMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMensagem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMensagem.Location = new System.Drawing.Point(43, 30);
            this.labelMensagem.MaximumSize = new System.Drawing.Size(382, 60);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(310, 60);
            this.labelMensagem.TabIndex = 3;
            this.labelMensagem.Text = "Ok?";
            // 
            // FormPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RascalApp.Properties.Resources.blackwood;
            this.ClientSize = new System.Drawing.Size(406, 190);
            this.ControlBox = false;
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.buttonSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rascal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSim;
        private System.Windows.Forms.Button buttonNao;
        private System.Windows.Forms.Label labelMensagem;
    }
}