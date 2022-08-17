namespace exercicio9_lista2
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
            this.labelDeposito = new System.Windows.Forms.Label();
            this.labelRendimento = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeposito
            // 
            this.labelDeposito.AutoSize = true;
            this.labelDeposito.Location = new System.Drawing.Point(64, 55);
            this.labelDeposito.Name = "labelDeposito";
            this.labelDeposito.Size = new System.Drawing.Size(92, 13);
            this.labelDeposito.TabIndex = 0;
            this.labelDeposito.Text = "Valor de depósito:";
            // 
            // labelRendimento
            // 
            this.labelRendimento.AutoSize = true;
            this.labelRendimento.Location = new System.Drawing.Point(64, 176);
            this.labelRendimento.Name = "labelRendimento";
            this.labelRendimento.Size = new System.Drawing.Size(137, 13);
            this.labelRendimento.TabIndex = 1;
            this.labelRendimento.Text = "Valor rendido após um mês:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(67, 107);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(231, 35);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(162, 52);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(136, 20);
            this.txtDeposito.TabIndex = 3;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(207, 176);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(15, 16);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 257);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelRendimento);
            this.Controls.Add(this.labelDeposito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeposito;
        private System.Windows.Forms.Label labelRendimento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label labelResultado;
    }
}

