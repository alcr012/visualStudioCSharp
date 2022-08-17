namespace exercicio14_lista2
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
            this.labelN1 = new System.Windows.Forms.Label();
            this.labelN2 = new System.Windows.Forms.Label();
            this.labelResponder = new System.Windows.Forms.Label();
            this.labelResposta = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Location = new System.Drawing.Point(51, 39);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(95, 13);
            this.labelN1.TabIndex = 0;
            this.labelN1.Text = "Insira o 1° número:";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(51, 88);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(95, 13);
            this.labelN2.TabIndex = 1;
            this.labelN2.Text = "Insira o 2° número:";
            // 
            // labelResponder
            // 
            this.labelResponder.AutoSize = true;
            this.labelResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponder.Location = new System.Drawing.Point(57, 216);
            this.labelResponder.Name = "labelResponder";
            this.labelResponder.Size = new System.Drawing.Size(65, 13);
            this.labelResponder.TabIndex = 2;
            this.labelResponder.Text = "O número:";
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta.Location = new System.Drawing.Point(128, 211);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(19, 20);
            this.labelResposta.TabIndex = 3;
            this.labelResposta.Text = "0";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(152, 36);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(122, 20);
            this.txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(152, 85);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(122, 20);
            this.txtN2.TabIndex = 5;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(54, 135);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(220, 39);
            this.btnAnalisar.TabIndex = 6;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.labelResposta);
            this.Controls.Add(this.labelResponder);
            this.Controls.Add(this.labelN2);
            this.Controls.Add(this.labelN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Label labelResponder;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnAnalisar;
    }
}

