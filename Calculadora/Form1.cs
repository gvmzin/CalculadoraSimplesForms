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

        private double valor1 = 0, valor2 = 0;
        private string operacao = "";
        private bool novoNumero = false;
        private List<string> historicoCompleto = new List<string>();
        private bool historicoVisivel = false;

        public Form1()
        {
            InitializeComponent();
            percent.Click += btnPorcentagem_Click;
            pow.Click += btnQuadrado_Click;
            btnHistorico.Click += btnHistorico_Click; // Associa o evento de clique do botão de histórico
            lstHistoricoCompleto.Visible = false; // Esconde o histórico completo inicialmente
            btnVirgula.Click += VirgulaClick;
            backspace.Click -= btnLimpar_Click; // Remove associação antiga, se houver
            backspace.Click += btnBackspace_Click;
        }

        private void NumeroClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (lblResult.Text == "0" || novoNumero)
            {
                lblResult.Text = btn.Text;
                novoNumero = false;
            }
            else
            {
                lblResult.Text += btn.Text;
            }

            lblResult.Visible = true;
        }

        private void VirgulaClick(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                lblResult.Text = "0,";
                novoNumero = false;
            }
            else if (!lblResult.Text.Contains(","))
            {
                lblResult.Text += ",";
            }
            lblResult.Visible = true;
        }

        private void OperacaoClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Tenta converter o texto do lblResult para double, considerando a cultura local (vírgula como separador decimal)
            double.TryParse(lblResult.Text, out valor1);
            operacao = btn.Text;
            novoNumero = true; // O próximo número digitado será o valor2
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double.TryParse(lblResult.Text, out valor2);
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
                        novoNumero = true;
                        operacao = "";
                        return;
                    }
                    break;
                case "%":
                    resultado = valor1 * (valor2 / 100.0);
                    break;
                case "x²":
                    resultado = Math.Pow(valor1, 2);
                    expressao = $"{valor1}²";
                    break;
            }
            lblResult.Text = resultado.ToString();
            lblResult.Visible = true;
            AdicionarAoHistorico($"{expressao} = {resultado}");
            novoNumero = true;
            operacao = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResult.Text) && lblResult.Text.Length > 1)
            {
                lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
            }
            else
            {
                lblResult.Text = "0";
            }
            lblResult.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            novoNumero = false;
            lblResult.Visible = true;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            // Se já existe um valor e operação, calcula a porcentagem do valor1 em relação ao valor2 e já executa a operação
            if (!string.IsNullOrEmpty(operacao))
            {
                double.TryParse(lblResult.Text, out valor2);
                double porcentagem = valor1 * (valor2 / 100.0);

                // Atualiza o lblResult para mostrar o valor da porcentagem
                lblResult.Text = porcentagem.ToString();

                // Executa a operação imediatamente
                double resultado = 0;
                string expressao = $"{valor1} {operacao} {porcentagem}";
                switch (operacao)
                {
                    case "+":
                        resultado = valor1 + porcentagem;
                        break;
                    case "-":
                        resultado = valor1 - porcentagem;
                        break;
                    case "*":
                        resultado = valor1 * porcentagem;
                        break;
                    case "/":
                        if (porcentagem != 0)
                            resultado = valor1 / porcentagem;
                        else
                        {
                            lblResult.Text = "Erro";
                            AdicionarAoHistorico($"{expressao} = Erro");
                            novoNumero = true;
                            operacao = "";
                            return;
                        }
                        break;
                }
                lblResult.Text = resultado.ToString();
                AdicionarAoHistorico($"{expressao} = {resultado}");
                novoNumero = true;
                operacao = ""; // Limpa a operação para novo cálculo
            }
            else
            {
                // Se não há operação, apenas converte o valor atual em porcentagem
                double.TryParse(lblResult.Text, out valor1);
                double resultado = valor1 / 100.0;
                lblResult.Text = resultado.ToString();
                AdicionarAoHistorico($"{valor1}% = {resultado}");
                novoNumero = true;
            }
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            double.TryParse(lblResult.Text, out valor1);
            double resultado = Math.Pow(valor1, 2);
            lblResult.Text = resultado.ToString();
            AdicionarAoHistorico($"{valor1}² = {resultado}");
            novoNumero = true;
        }

        private void AdicionarAoHistorico(string item)
        {
            historicoCompleto.Add(item);
            lblHistorico.Text = item;
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
                lstHistoricoCompleto.Visible = false;
                btnHistorico.Text = "Histórico";
                historicoVisivel = false;
            }
        }
    }
}
