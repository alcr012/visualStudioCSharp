namespace exercicio5_lista2
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
            this.labelNomeAluno = new System.Windows.Forms.Label();
            this.labeN1 = new System.Windows.Forms.Label();
            this.labelN2 = new System.Windows.Forms.Label();
            this.labelN3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.btnMedia = new System.Windows.Forms.Button();
            this.labelMedia = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNomeResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Location = new System.Drawing.Point(48, 65);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(82, 13);
            this.labelNomeAluno.TabIndex = 0;
            this.labelNomeAluno.Text = "Nome do aluno:";
            // 
            // labeN1
            // 
            this.labeN1.AutoSize = true;
            this.labeN1.Location = new System.Drawing.Point(48, 104);
            this.labeN1.Name = "labeN1";
            this.labeN1.Size = new System.Drawing.Size(44, 13);
            this.labeN1.TabIndex = 1;
            this.labeN1.Text = "1° nota:";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(48, 137);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(44, 13);
            this.labelN2.TabIndex = 2;
            this.labelN2.Text = "2° nota:";
            // 
            // labelN3
            // 
            this.labelN3.AutoSize = true;
            this.labelN3.Location = new System.Drawing.Point(48, 176);
            this.labelN3.Name = "labelN3";
            this.labelN3.Size = new System.Drawing.Size(44, 13);
            this.labelN3.TabIndex = 3;
            this.labelN3.Text = "3° nota:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(155, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(155, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(155, 101);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(155, 20);
            this.txtN1.TabIndex = 5;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(155, 137);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(155, 20);
            this.txtN2.TabIndex = 6;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(155, 173);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(155, 20);
            this.txtN3.TabIndex = 7;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(51, 223);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(258, 34);
            this.btnMedia.TabIndex = 8;
            this.btnMedia.Text = "Calcular média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Location = new System.Drawing.Point(51, 339);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(39, 13);
            this.labelMedia.TabIndex = 9;
            this.labelMedia.Text = "Média:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(115, 336);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(15, 16);
            this.labelResultado.TabIndex = 10;
            this.labelResultado.Text = "0";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(51, 299);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 11;
            this.labelNome.Text = "Nome:";
            // 
            // labelNomeResultado
            // 
            this.labelNomeResultado.AutoSize = true;
            this.labelNomeResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeResultado.Location = new System.Drawing.Point(115, 299);
            this.labelNomeResultado.Name = "labelNomeResultado";
            this.labelNomeResultado.Size = new System.Drawing.Size(15, 16);
            this.labelNomeResultado.TabIndex = 12;
            this.labelNomeResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 418);
            this.Controls.Add(this.labelNomeResultado);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelN3);
            this.Controls.Add(this.labelN2);
            this.Controls.Add(this.labeN1);
            this.Controls.Add(this.labelNomeAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeAluno;
        private System.Windows.Forms.Label labeN1;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Label labelN3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNomeResultado;
    }
}

