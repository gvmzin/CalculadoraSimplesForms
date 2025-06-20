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
        // Componentes da interface
        private System.Windows.Forms.Button btnVerHistorico;
        private System.Windows.Forms.ListBox lstHistorico;

        // Variáveis para armazenar os valores e a operação
        private double valor1 = 0, valor2 = 0;
        private string operacao = "";
        private bool novoNumero = false;
        private List<string> historicoCompleto = new List<string>();
        private bool historicoVisivel = false;

        // Método para inicializar os componentes da interface
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

        // Método para lidar com o clique nos botões numéricos
        private void NumeroClick(object sender, EventArgs e) 
        {
            Button btn = sender as Button;

            // Verifica se o botão clicado é um número ou a vírgula
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

        // Método para lidar com o clique na vírgula
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

        // Método para lidar com o clique nas operações
        private void OperacaoClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Tenta converter o texto do lblResult para double, considerando a cultura local (vírgula como separador decimal)
            double.TryParse(lblResult.Text, out valor1);
            operacao = btn.Text;
            novoNumero = true; // O próximo número digitado será o valor2
        }

        // Método para lidar com o clique no botão de igual
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
                    if (valor2 != 0) // Verifica se o divisor é diferente de zero para evitar divisão por zero
                        resultado = valor1 / valor2;
                    else // Se for zero, exibe erro
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

        // Método para lidar com o clique no botão de backspace
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResult.Text) && lblResult.Text.Length > 1) // Verifica se há mais de um caractere
            {
                lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
            }
            else // Se só houver um caractere ou estiver vazio, reseta para "0"
            {
                lblResult.Text = "0";
            }
            lblResult.Visible = true;
        }

        // Método para lidar com o clique no botão de limpar
        private void btnLimpar_Click(object sender, EventArgs e) // Limpa todos os valores e reseta a calculadora
        {
            lblResult.Text = "0";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            novoNumero = false;
            lblResult.Visible = true;
        }

        // Método para lidar com o clique no botão de porcentagem
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

        // Método para lidar com o clique no botão de quadrado
        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            double.TryParse(lblResult.Text, out valor1);
            double resultado = Math.Pow(valor1, 2);
            lblResult.Text = resultado.ToString();
            AdicionarAoHistorico($"{valor1}² = {resultado}");
            novoNumero = true;
        }

        // Método para adicionar uma expressão ao histórico e atualizar o label de histórico
        private void AdicionarAoHistorico(string item)
        {
            historicoCompleto.Add(item);
            lblHistorico.Text = item;
        }

        // Método para lidar com o clique no botão de histórico
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
