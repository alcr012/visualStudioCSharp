namespace exercicio12_lista2
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
            this.labelValorFabrica = new System.Windows.Forms.Label();
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.txtValorFabrica = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValorFabrica
            // 
            this.labelValorFabrica.AutoSize = true;
            this.labelValorFabrica.Location = new System.Drawing.Point(55, 46);
            this.labelValorFabrica.Name = "labelValorFabrica";
            this.labelValorFabrica.Size = new System.Drawing.Size(84, 13);
            this.labelValorFabrica.TabIndex = 0;
            this.labelValorFabrica.Text = "Valor de fábrica:";
            // 
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.Location = new System.Drawing.Point(55, 197);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(82, 13);
            this.labelValorVenda.TabIndex = 1;
            this.labelValorVenda.Text = "Valor de venda:";
            // 
            // txtValorFabrica
            // 
            this.txtValorFabrica.Location = new System.Drawing.Point(145, 43);
            this.txtValorFabrica.Name = "txtValorFabrica";
            this.txtValorFabrica.Size = new System.Drawing.Size(115, 20);
            this.txtValorFabrica.TabIndex = 2;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(142, 197);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(15, 16);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(58, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(202, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 267);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtValorFabrica);
            this.Controls.Add(this.labelValorVenda);
            this.Controls.Add(this.labelValorFabrica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValorFabrica;
        private System.Windows.Forms.Label labelValorVenda;
        private System.Windows.Forms.TextBox txtValorFabrica;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

