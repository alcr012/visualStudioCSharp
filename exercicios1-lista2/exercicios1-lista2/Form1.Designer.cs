namespace exercicios1_lista2
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.labelN1 = new System.Windows.Forms.Label();
            this.labelN2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(161, 70);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(149, 20);
            this.txtN1.TabIndex = 0;
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Location = new System.Drawing.Point(45, 73);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(97, 13);
            this.labelN1.TabIndex = 1;
            this.labelN1.Text = "Digite o 1° número:";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(45, 121);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(97, 13);
            this.labelN2.TabIndex = 2;
            this.labelN2.Text = "Digite o 2° número:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(45, 199);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(58, 13);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "Resultado:";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(161, 121);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(149, 20);
            this.txtN2.TabIndex = 4;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(161, 196);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(149, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(48, 159);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(262, 23);
            this.btnSomar.TabIndex = 6;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 354);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelN2);
            this.Controls.Add(this.labelN1);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSomar;
    }
}

