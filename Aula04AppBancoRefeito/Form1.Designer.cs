
namespace Aula04AppBancoRefeito
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
            this.lblConrado = new System.Windows.Forms.Label();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblInformeValor = new System.Windows.Forms.Label();
            this.textInformeValor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConrado
            // 
            this.lblConrado.AutoSize = true;
            this.lblConrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConrado.Location = new System.Drawing.Point(51, 19);
            this.lblConrado.Name = "lblConrado";
            this.lblConrado.Size = new System.Drawing.Size(152, 22);
            this.lblConrado.TabIndex = 0;
            this.lblConrado.Text = "Conrado\'s Bank";
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtual.Location = new System.Drawing.Point(52, 58);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(126, 17);
            this.lblSaldoAtual.TabIndex = 1;
            this.lblSaldoAtual.Text = "Seu saldo atual:";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(51, 75);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(52, 22);
            this.lblReal.TabIndex = 2;
            this.lblReal.Text = "R$ 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnSacar);
            this.groupBox1.Controls.Add(this.btnDepositar);
            this.groupBox1.Location = new System.Drawing.Point(55, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações Disponiveis";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(19, 29);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(147, 62);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(215, 29);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(147, 62);
            this.btnSacar.TabIndex = 1;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.textInformeValor);
            this.panel1.Controls.Add(this.lblInformeValor);
            this.panel1.Controls.Add(this.lblDeposito);
            this.panel1.Location = new System.Drawing.Point(19, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 150);
            this.panel1.TabIndex = 2;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(15, 4);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(89, 22);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito";
            // 
            // lblInformeValor
            // 
            this.lblInformeValor.AutoSize = true;
            this.lblInformeValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeValor.Location = new System.Drawing.Point(15, 45);
            this.lblInformeValor.Name = "lblInformeValor";
            this.lblInformeValor.Size = new System.Drawing.Size(106, 17);
            this.lblInformeValor.TabIndex = 1;
            this.lblInformeValor.Text = "Informe o valor:";
            // 
            // textInformeValor
            // 
            this.textInformeValor.Location = new System.Drawing.Point(18, 65);
            this.textInformeValor.Name = "textInformeValor";
            this.textInformeValor.Size = new System.Drawing.Size(304, 20);
            this.textInformeValor.TabIndex = 2;
            this.textInformeValor.TextChanged += new System.EventHandler(this.textInformeValor_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(125, 95);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 39);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.Location = new System.Drawing.Point(283, 62);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(102, 35);
            this.btnExtrato.TabIndex = 4;
            this.btnExtrato.Text = "Ver extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 440);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.lblSaldoAtual);
            this.Controls.Add(this.lblConrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConrado;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox textInformeValor;
        private System.Windows.Forms.Label lblInformeValor;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnExtrato;
    }
}

