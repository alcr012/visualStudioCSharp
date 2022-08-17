namespace exercicio8_lista2
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
            this.labelDolar = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.labelValorDolar = new System.Windows.Forms.Label();
            this.txtValorDolar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Location = new System.Drawing.Point(37, 52);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(77, 13);
            this.labelDolar.TabIndex = 0;
            this.labelDolar.Text = "Valor em dólar:";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(138, 49);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(129, 20);
            this.txtDolar.TabIndex = 1;
            // 
            // labelValorDolar
            // 
            this.labelValorDolar.AutoSize = true;
            this.labelValorDolar.Location = new System.Drawing.Point(37, 107);
            this.labelValorDolar.Name = "labelValorDolar";
            this.labelValorDolar.Size = new System.Drawing.Size(75, 13);
            this.labelValorDolar.TabIndex = 2;
            this.labelValorDolar.Text = "Valor do dólar:";
            // 
            // txtValorDolar
            // 
            this.txtValorDolar.Location = new System.Drawing.Point(138, 104);
            this.txtValorDolar.Name = "txtValorDolar";
            this.txtValorDolar.Size = new System.Drawing.Size(129, 20);
            this.txtValorDolar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor em reais é:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(155, 247);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(15, 16);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(40, 154);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(227, 38);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 325);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorDolar);
            this.Controls.Add(this.labelValorDolar);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.labelDolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label labelValorDolar;
        private System.Windows.Forms.TextBox txtValorDolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

