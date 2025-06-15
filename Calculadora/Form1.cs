using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button btnVerHistorico;
        private System.Windows.Forms.ListBox lstHistorico;

        double valor1 = 0, valor2 = 0;
        string operacao = "";
        List<string> historicoCompleto = new List<string>();
        private bool historicoVisivel = false;

        public Form1()
        {
            InitializeComponent();
            btnHistorico.Click += btnHistorico_Click;
            lstHistoricoCompleto.Visible = false;
        }

        private void NumeroClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Se o resultado está em "0" ou foi feita uma operação, inicia novo número
            if (lblResult.Text == "0" || (operacao != "" && lblNumberTwo.Text == ""))
                lblResult.Text = btn.Text;
            else
                lblResult.Text += btn.Text;

            if (operacao == "")
            {
                lblNumberOne.Text = lblResult.Text;
                lblNumberTwo.Text = "";
            }
            else
            {
                lblNumberTwo.Text = lblResult.Text;
            }
            lblResult.Visible = true;
        }

        private void OperacaoClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            valor1 = double.Parse(lblResult.Text);
            operacao = btn.Text;
            lblSing.Text = operacao;
            lblNumberOne.Text = valor1.ToString();
            lblResult.Visible = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(lblResult.Text);
            lblNumberTwo.Text = valor2.ToString();
            double resultado = 0;
            string expressao = $"{valor1} {operacao} {valor2}";
            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                    {
                        lblResult.Text = "Erro";
                        AdicionarAoHistorico($"{expressao} = Erro");
                        return;
                    }
                    break;
            }
            lblResult.Text = resultado.ToString();
            lblResult.Visible = true;
            AdicionarAoHistorico($"{expressao} = {resultado}");
        }

        private void AdicionarAoHistorico(string item)
        {
            historicoCompleto.Add(item);
            lblHistorico.Text = item; // Atualiza o label com o último cálculo
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            lblNumberOne.Text = "";
            lblNumberTwo.Text = "";
            lblSing.Text = "";
            lblResult.Visible = true;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            if (!historicoVisivel)
            {
                lstHistoricoCompleto.Items.Clear();
                foreach (var item in historicoCompleto)
                {
                    lstHistoricoCompleto.Items.Add(new ListViewItem(item));
                }
                lstHistoricoCompleto.Visible = true;
                btnHistorico.Text = "Esconder Histórico";
                historicoVisivel = true;
            }
            else
            {
                EsconderHistorico();
            }
        }

        private void EsconderHistorico()
        {
            lstHistoricoCompleto.Visible = false;
            btnHistorico.Text = "Histórico";
            historicoVisivel = false;
        }

        private void btnVerHistorico_Click(object sender, EventArgs e)
        {
            if (!historicoVisivel)
            {
                lstHistorico.Items.Clear();
                foreach (var item in historicoCompleto)
                {
                    lstHistorico.Items.Add(item);
                }
                lstHistorico.Visible = true;
                btnVerHistorico.Text = "Esconder Histórico";
                historicoVisivel = true;
            }
            else
            {
                EsconderHistorico();
            }
        }
    }
}
