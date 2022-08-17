namespace exercicio13_lista2
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.labelResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(49, 42);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(90, 13);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "Insira um número:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(49, 180);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(65, 13);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "O número é:";
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(52, 91);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(234, 35);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(145, 39);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(141, 20);
            this.txtN.TabIndex = 3;
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta.Location = new System.Drawing.Point(133, 180);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(15, 16);
            this.labelResposta.TabIndex = 4;
            this.labelResposta.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 251);
            this.Controls.Add(this.labelResposta);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label labelResposta;
    }
}

