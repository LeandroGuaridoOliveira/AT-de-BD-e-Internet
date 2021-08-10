
namespace ATBDEX11
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPesoVeiculo = new System.Windows.Forms.TextBox();
            this.txtAlturaVeiculo = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(33, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "restrição de trafego";
            // 
            // txtPesoVeiculo
            // 
            this.txtPesoVeiculo.Location = new System.Drawing.Point(96, 157);
            this.txtPesoVeiculo.Name = "txtPesoVeiculo";
            this.txtPesoVeiculo.Size = new System.Drawing.Size(167, 20);
            this.txtPesoVeiculo.TabIndex = 1;
            // 
            // txtAlturaVeiculo
            // 
            this.txtAlturaVeiculo.Location = new System.Drawing.Point(96, 227);
            this.txtAlturaVeiculo.Name = "txtAlturaVeiculo";
            this.txtAlturaVeiculo.Size = new System.Drawing.Size(167, 20);
            this.txtAlturaVeiculo.TabIndex = 2;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(96, 129);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(167, 13);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Digite aqui o peso do seu veiculo:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(95, 195);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(168, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "digite aqui a altura do seu veiculo:";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.Location = new System.Drawing.Point(99, 308);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(164, 61);
            this.btnCalculo.TabIndex = 5;
            this.btnCalculo.Text = "ver pontes disponiveis";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 428);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAlturaVeiculo);
            this.Controls.Add(this.txtPesoVeiculo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPesoVeiculo;
        private System.Windows.Forms.TextBox txtAlturaVeiculo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnCalculo;
    }
}

