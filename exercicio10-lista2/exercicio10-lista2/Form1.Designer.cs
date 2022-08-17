namespace exercicio10_lista2
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
            this.labelValorCompra = new System.Windows.Forms.Label();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValorCompra
            // 
            this.labelValorCompra.AutoSize = true;
            this.labelValorCompra.Location = new System.Drawing.Point(64, 53);
            this.labelValorCompra.Name = "labelValorCompra";
            this.labelValorCompra.Size = new System.Drawing.Size(87, 13);
            this.labelValorCompra.TabIndex = 0;
            this.labelValorCompra.Text = "Valor da compra:";
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Location = new System.Drawing.Point(64, 190);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.Size = new System.Drawing.Size(126, 13);
            this.labelValorFinal.TabIndex = 1;
            this.labelValorFinal.Text = "Valor de cada prestação:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(214, 190);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(15, 16);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Text = "0";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(157, 50);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(127, 20);
            this.txtValor.TabIndex = 4;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(67, 110);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(217, 42);
            this.btnDividir.TabIndex = 5;
            this.btnDividir.Text = "Dividir Compra";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 287);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelValorFinal);
            this.Controls.Add(this.labelValorCompra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValorCompra;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDividir;
    }
}

