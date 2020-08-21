namespace WinAloMundo
    {
    partial class FrmPrincipal
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
            this.btnFazer = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFazer
            // 
            this.btnFazer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFazer.ForeColor = System.Drawing.Color.DeepPink;
            this.btnFazer.Location = new System.Drawing.Point(210, 79);
            this.btnFazer.Name = "btnFazer";
            this.btnFazer.Size = new System.Drawing.Size(75, 23);
            this.btnFazer.TabIndex = 0;
            this.btnFazer.Text = "Fazer";
            this.btnFazer.UseVisualStyleBackColor = false;
            this.btnFazer.Click += new System.EventHandler(this.btnFazer_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(31, 81);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(161, 20);
            this.txtTexto.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(327, 159);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnFazer);
            this.Name = "FrmPrincipal";
            this.Text = "Janela Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btnFazer;
        private System.Windows.Forms.TextBox txtTexto;
        }
    }

