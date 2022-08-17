namespace exercicio3_lista2
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
            this.labelDistancia = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.labelConsumo = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Location = new System.Drawing.Point(51, 70);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(77, 13);
            this.labelDistancia.TabIndex = 0;
            this.labelDistancia.Text = "Distância total:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(51, 133);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(98, 13);
            this.labelCombustivel.TabIndex = 1;
            this.labelCombustivel.Text = "Combustível gasto:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(166, 70);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(159, 20);
            this.txtDistancia.TabIndex = 2;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Location = new System.Drawing.Point(166, 130);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(159, 20);
            this.txtCombustivel.TabIndex = 3;
            // 
            // labelConsumo
            // 
            this.labelConsumo.AutoSize = true;
            this.labelConsumo.Location = new System.Drawing.Point(51, 274);
            this.labelConsumo.Name = "labelConsumo";
            this.labelConsumo.Size = new System.Drawing.Size(85, 13);
            this.labelConsumo.TabIndex = 4;
            this.labelConsumo.Text = "Consumo médio:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(163, 274);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(15, 16);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "0";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(54, 188);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(271, 50);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelConsumo);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.labelDistancia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.Label labelConsumo;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label label1;
    }
}

