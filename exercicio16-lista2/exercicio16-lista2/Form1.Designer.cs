namespace exercicio16_lista2
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
            this.labelN3 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelAluno = new System.Windows.Forms.Label();
            this.labelNomeFinal = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Location = new System.Drawing.Point(60, 83);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(81, 13);
            this.labelN1.TabIndex = 0;
            this.labelN1.Text = "Insira a 1° nota:";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(60, 123);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(81, 13);
            this.labelN2.TabIndex = 1;
            this.labelN2.Text = "Insira a 2° nota:";
            // 
            // labelN3
            // 
            this.labelN3.AutoSize = true;
            this.labelN3.Location = new System.Drawing.Point(60, 162);
            this.labelN3.Name = "labelN3";
            this.labelN3.Size = new System.Drawing.Size(81, 13);
            this.labelN3.TabIndex = 2;
            this.labelN3.Text = "Insira a 3° nota:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(60, 45);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(117, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Insira o nome do aluno:";
            // 
            // labelAluno
            // 
            this.labelAluno.AutoSize = true;
            this.labelAluno.Location = new System.Drawing.Point(71, 297);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(47, 13);
            this.labelAluno.TabIndex = 4;
            this.labelAluno.Text = "O aluno:";
            // 
            // labelNomeFinal
            // 
            this.labelNomeFinal.AutoSize = true;
            this.labelNomeFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeFinal.Location = new System.Drawing.Point(126, 297);
            this.labelNomeFinal.Name = "labelNomeFinal";
            this.labelNomeFinal.Size = new System.Drawing.Size(15, 16);
            this.labelNomeFinal.TabIndex = 5;
            this.labelNomeFinal.Text = "0";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(258, 297);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(15, 16);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "0";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(183, 80);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(184, 20);
            this.txtN1.TabIndex = 7;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(183, 120);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(184, 20);
            this.txtN2.TabIndex = 8;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(183, 159);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(184, 20);
            this.txtN3.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(63, 213);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(304, 38);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular média";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(435, 413);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNomeFinal);
            this.Controls.Add(this.labelAluno);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelN3);
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
        private System.Windows.Forms.Label labelN3;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.Label labelNomeFinal;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCalcular;
    }
}

