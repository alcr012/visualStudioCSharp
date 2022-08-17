namespace exercicio15_lista2
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
            this.labelN = new System.Windows.Forms.Label();
            this.labelResponder = new System.Windows.Forms.Label();
            this.labelResposta = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(47, 41);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(99, 13);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "Insira o um número:";
            // 
            // labelResponder
            // 
            this.labelResponder.AutoSize = true;
            this.labelResponder.Location = new System.Drawing.Point(50, 147);
            this.labelResponder.Name = "labelResponder";
            this.labelResponder.Size = new System.Drawing.Size(56, 13);
            this.labelResponder.TabIndex = 1;
            this.labelResponder.Text = "O número:";
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta.Location = new System.Drawing.Point(112, 144);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(15, 16);
            this.labelResposta.TabIndex = 2;
            this.labelResposta.Text = "0";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(152, 38);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(116, 20);
            this.txtN.TabIndex = 3;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(50, 88);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(218, 36);
            this.btnAnalisar.TabIndex = 4;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 211);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.labelResposta);
            this.Controls.Add(this.labelResponder);
            this.Controls.Add(this.labelN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelResponder;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnAnalisar;
    }
}

