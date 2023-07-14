using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBancoRefeito
{
    public partial class Form1 : Form
    {
        //variavel global
        List<string> extratos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblDeposito.Text == "Sacar")
            {
                double dinheiro = double.Parse(textInformeValor.Text);
                if (dinheiro < 0)
                {
                    return;
                }
                double saldo = double.Parse(lblReal.Text.Replace("R$", ""));
                double subtracao = saldo - dinheiro;
                extratos.Add("Saque no valor de " + dinheiro);
                if (subtracao < 0)
                {
                    MessageBox.Show("Saldo insuficiente!!!");
                    return;
                }
                lblReal.Text = $"R$ {subtracao}";
            }
            else
            {


                double dinheiro = double.Parse(textInformeValor.Text);
                if (dinheiro < 0)
                {
                    return;
                }
                double saldo = double.Parse(lblReal.Text.Replace("R$", ""));
                double soma = dinheiro + saldo;
                extratos.Add("Depósito no valor de " + soma);
                lblReal.Text = $"R$ {soma}";
            }
            
            
            
            /* double saldo = double.Parse(lblValorDinheiro.Text);
            double valor = double.Parse(textInformeValor.Text);
            double soma = saldo + valor;
            lblValorDinheiro.Text = $"{soma}";*/
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnDepositar.BackColor = Color.Gainsboro;
            btnDepositar.ForeColor = Color.Black;
            btnSacar.BackColor = Color.LightBlue;
            btnSacar.ForeColor = Color.DodgerBlue;
            lblDeposito.Text = "Sacar";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnSacar.BackColor = Color.Gainsboro;
            btnSacar.ForeColor = Color.Black;
            btnDepositar.BackColor = Color.LightBlue;
            btnDepositar.ForeColor = Color.DodgerBlue;
            lblDeposito.Text = "Depositar";
        }

        private void textInformeValor_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Form2 telaExtrato = new Form2();
            telaExtrato.extratos = extratos;
            telaExtrato.Show();
        }
    }
}
