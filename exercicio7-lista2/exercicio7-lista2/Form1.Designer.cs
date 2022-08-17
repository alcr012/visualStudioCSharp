namespace exercicio7_lista2
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
            this.labelC = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.btnConversor = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(32, 52);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(58, 13);
            this.labelC.TabIndex = 0;
            this.labelC.Text = "Insira o °C:";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(32, 162);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(20, 13);
            this.labelF.TabIndex = 1;
            this.labelF.Text = "°F:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(73, 162);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(15, 16);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Text = "0";
            // 
            // btnConversor
            // 
            this.btnConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversor.Location = new System.Drawing.Point(35, 91);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(203, 32);
            this.btnConversor.TabIndex = 4;
            this.btnConversor.Text = "Conversor";
            this.btnConversor.UseVisualStyleBackColor = true;
            this.btnConversor.Click += new System.EventHandler(this.btnConversor_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(96, 49);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(142, 20);
            this.txtC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CONVERSOR DE °C EM °F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 319);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnConversor);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btnConversor;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
    }
}

