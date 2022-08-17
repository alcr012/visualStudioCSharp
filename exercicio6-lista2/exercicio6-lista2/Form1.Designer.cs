namespace exercicio6_lista2
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
            this.label = new System.Windows.Forms.Label();
            this.labelValorN1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnInverter = new System.Windows.Forms.Button();
            this.labelValor1 = new System.Windows.Forms.Label();
            this.labelValorN2 = new System.Windows.Forms.Label();
            this.labelValor2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Location = new System.Drawing.Point(77, 54);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(83, 13);
            this.labelN1.TabIndex = 0;
            this.labelN1.Text = "Insira o 1° valor:";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(77, 100);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(83, 13);
            this.labelN2.TabIndex = 1;
            this.labelN2.Text = "Insira o 2° valor:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(77, 282);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 2;
            // 
            // labelValorN1
            // 
            this.labelValorN1.AutoSize = true;
            this.labelValorN1.Location = new System.Drawing.Point(138, 254);
            this.labelValorN1.Name = "labelValorN1";
            this.labelValorN1.Size = new System.Drawing.Size(13, 13);
            this.labelValorN1.TabIndex = 3;
            this.labelValorN1.Text = "0";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(166, 51);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(138, 20);
            this.txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(166, 97);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(138, 20);
            this.txtN2.TabIndex = 5;
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(80, 158);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(224, 39);
            this.btnInverter.TabIndex = 6;
            this.btnInverter.Text = "Inversão";
            this.btnInverter.UseVisualStyleBackColor = true;
            // 
            // labelValor1
            // 
            this.labelValor1.AutoSize = true;
            this.labelValor1.Location = new System.Drawing.Point(77, 254);
            this.labelValor1.Name = "labelValor1";
            this.labelValor1.Size = new System.Drawing.Size(46, 13);
            this.labelValor1.TabIndex = 7;
            this.labelValor1.Text = "1° valor:";
            // 
            // labelValorN2
            // 
            this.labelValorN2.AutoSize = true;
            this.labelValorN2.Location = new System.Drawing.Point(285, 254);
            this.labelValorN2.Name = "labelValorN2";
            this.labelValorN2.Size = new System.Drawing.Size(13, 13);
            this.labelValorN2.TabIndex = 8;
            this.labelValorN2.Text = "0";
            // 
            // labelValor2
            // 
            this.labelValor2.AutoSize = true;
            this.labelValor2.Location = new System.Drawing.Point(224, 254);
            this.labelValor2.Name = "labelValor2";
            this.labelValor2.Size = new System.Drawing.Size(46, 13);
            this.labelValor2.TabIndex = 9;
            this.labelValor2.Text = "2° valor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelValor2);
            this.Controls.Add(this.labelValorN2);
            this.Controls.Add(this.labelValor1);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.labelValorN1);
            this.Controls.Add(this.label);
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
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelValorN1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Label labelValor1;
        private System.Windows.Forms.Label labelValorN2;
        private System.Windows.Forms.Label labelValor2;
    }
}

