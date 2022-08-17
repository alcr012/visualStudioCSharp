namespace exercicio4_lista2
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSalarioFixo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.labelComissao = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelSalarioFim = new System.Windows.Forms.Label();
            this.labelSalarioFinalResultado = new System.Windows.Forms.Label();
            this.labelSalarioFinal = new System.Windows.Forms.Label();
            this.labelNomeFim = new System.Windows.Forms.Label();
            this.labelNomeResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(55, 58);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(101, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome do vendedor:";
            // 
            // labelSalarioFixo
            // 
            this.labelSalarioFixo.AutoSize = true;
            this.labelSalarioFixo.Location = new System.Drawing.Point(55, 109);
            this.labelSalarioFixo.Name = "labelSalarioFixo";
            this.labelSalarioFixo.Size = new System.Drawing.Size(61, 13);
            this.labelSalarioFixo.TabIndex = 1;
            this.labelSalarioFixo.Text = "Salário fixo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(163, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(163, 106);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(177, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // labelComissao
            // 
            this.labelComissao.AutoSize = true;
            this.labelComissao.Location = new System.Drawing.Point(55, 158);
            this.labelComissao.Name = "labelComissao";
            this.labelComissao.Size = new System.Drawing.Size(87, 13);
            this.labelComissao.TabIndex = 4;
            this.labelComissao.Text = "Valor de vendas:";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(163, 158);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(177, 20);
            this.txtComissao.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(58, 223);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(281, 44);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelSalarioFim
            // 
            this.labelSalarioFim.AutoSize = true;
            this.labelSalarioFim.Location = new System.Drawing.Point(55, 359);
            this.labelSalarioFim.Name = "labelSalarioFim";
            this.labelSalarioFim.Size = new System.Drawing.Size(116, 13);
            this.labelSalarioFim.TabIndex = 9;
            this.labelSalarioFim.Text = "Salário do final do mês:";
            // 
            // labelSalarioFinalResultado
            // 
            this.labelSalarioFinalResultado.AutoSize = true;
            this.labelSalarioFinalResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalarioFinalResultado.Location = new System.Drawing.Point(198, 356);
            this.labelSalarioFinalResultado.Name = "labelSalarioFinalResultado";
            this.labelSalarioFinalResultado.Size = new System.Drawing.Size(0, 16);
            this.labelSalarioFinalResultado.TabIndex = 12;
            // 
            // labelSalarioFinal
            // 
            this.labelSalarioFinal.AutoSize = true;
            this.labelSalarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalarioFinal.Location = new System.Drawing.Point(183, 359);
            this.labelSalarioFinal.Name = "labelSalarioFinal";
            this.labelSalarioFinal.Size = new System.Drawing.Size(15, 16);
            this.labelSalarioFinal.TabIndex = 14;
            this.labelSalarioFinal.Text = "0";
            // 
            // labelNomeFim
            // 
            this.labelNomeFim.AutoSize = true;
            this.labelNomeFim.Location = new System.Drawing.Point(58, 330);
            this.labelNomeFim.Name = "labelNomeFim";
            this.labelNomeFim.Size = new System.Drawing.Size(56, 13);
            this.labelNomeFim.TabIndex = 15;
            this.labelNomeFim.Text = "Vendedor:";
            // 
            // labelNomeResultado
            // 
            this.labelNomeResultado.AutoSize = true;
            this.labelNomeResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeResultado.Location = new System.Drawing.Point(183, 330);
            this.labelNomeResultado.Name = "labelNomeResultado";
            this.labelNomeResultado.Size = new System.Drawing.Size(15, 16);
            this.labelNomeResultado.TabIndex = 18;
            this.labelNomeResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 474);
            this.Controls.Add(this.labelNomeResultado);
            this.Controls.Add(this.labelNomeFim);
            this.Controls.Add(this.labelSalarioFinal);
            this.Controls.Add(this.labelSalarioFinalResultado);
            this.Controls.Add(this.labelSalarioFim);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.labelComissao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelSalarioFixo);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSalarioFixo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label labelComissao;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labelSalarioFim;
        private System.Windows.Forms.Label labelSalarioFinalResultado;
        private System.Windows.Forms.Label labelSalarioFinal;
        private System.Windows.Forms.Label labelNomeFim;
        private System.Windows.Forms.Label labelNomeResultado;
    }
}

