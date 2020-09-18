namespace day02
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeia = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.txtSubs = new System.Windows.Forms.TextBox();
            this.txtVerbo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeia
            // 
            this.btnLeia.Location = new System.Drawing.Point(21, 12);
            this.btnLeia.Name = "btnLeia";
            this.btnLeia.Size = new System.Drawing.Size(122, 34);
            this.btnLeia.TabIndex = 0;
            this.btnLeia.Text = "leia";
            this.btnLeia.UseVisualStyleBackColor = true;
            this.btnLeia.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(21, 65);
            this.txtInput.MaxLength = 6000000;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(523, 180);
            this.txtInput.TabIndex = 1;
            // 
            // txtQnt
            // 
            this.txtQnt.Location = new System.Drawing.Point(561, 65);
            this.txtQnt.Multiline = true;
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(87, 42);
            this.txtQnt.TabIndex = 1;
            // 
            // txtSubs
            // 
            this.txtSubs.Location = new System.Drawing.Point(561, 136);
            this.txtSubs.Name = "txtSubs";
            this.txtSubs.Size = new System.Drawing.Size(100, 20);
            this.txtSubs.TabIndex = 2;
            // 
            // txtVerbo
            // 
            this.txtVerbo.Location = new System.Drawing.Point(561, 163);
            this.txtVerbo.Name = "txtVerbo";
            this.txtVerbo.Size = new System.Drawing.Size(100, 20);
            this.txtVerbo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVerbo);
            this.Controls.Add(this.txtSubs);
            this.Controls.Add(this.txtQnt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnLeia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeia;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.TextBox txtSubs;
        private System.Windows.Forms.TextBox txtVerbo;
    }
}

