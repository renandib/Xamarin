using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalc
{
    public partial class MainPage : ContentPage
    {
        // CRIANDO VARIAVEIS INICIAIS > QUE FARAO A COLETA DOS DADOS E A OPERACAO QUE EU QUERO 
        string operacao = null;

        double memoria_de_calculo_pre_operacao = 0.0;
        double memoria_de_calculo_pos_operacao = 0.0;

        string para_aparecer_no_visor = "";

        public MainPage()
        {
            InitializeComponent();
        }

        // CRIANDO FUNCAO PARA APAGAR OS SINAIS DO VISOR E DEIXAR MENOS POLUIDO
        private void remover_sinais_visor()
        {
            if (para_aparecer_no_visor == "+" || para_aparecer_no_visor == "-"
                || para_aparecer_no_visor == "*" || para_aparecer_no_visor == "/")
            {
                para_aparecer_no_visor = "";
            }
        }

        // CRIANDO FUNCAO PARA O BOTÃO "=" > PRINCIPAL FUNCAO Q VAI EXECUTAR O CALCULO E OS BOTOES 

        private void btn_igual(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pos_operacao = Convert.ToDouble(visor.Text);

                double resultado = 0;

                if (operacao == "+")
                {
                    resultado = memoria_de_calculo_pre_operacao + memoria_de_calculo_pos_operacao;
                }

                else if (operacao == "-")
                {

                    resultado = memoria_de_calculo_pre_operacao - memoria_de_calculo_pos_operacao;
                }

                else if (operacao == "*")
                {
                    resultado = memoria_de_calculo_pre_operacao * memoria_de_calculo_pos_operacao;

                }

                else if (operacao == "/")
                {
                    resultado = memoria_de_calculo_pre_operacao / memoria_de_calculo_pos_operacao;
                }

                visor.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;

            }
        }


        // CRIANDO AGORA A FUNCIONALIDADE DOS BOTOES DAS OPERACOES e tbm EXIBINDO NA LABEL VISOR PRINCIPAL

        private void btn_somar(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "+";
            operacao = "+";
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_subtrair(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "-";
            operacao = "-";
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_multi(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "*";
            operacao = "*";
            visor.Text = para_aparecer_no_visor;

        }

        private void btn_dividir(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "/";
            operacao = "/";
            visor.Text = para_aparecer_no_visor;
        }

        // AGORA VOU CRIAR AS FUNCOES DOS OUTROS BOTOES DE 0 ATE 9

        private void btn_0(object sender, EventArgs e)  // criei o botao 0 > agora falta ous outrs
        {
            remover_sinais_visor(); // para remover os sinais das operacoes > so aparecer os numeros mesmo 

            para_aparecer_no_visor += num0.Text;
            visor.Text = para_aparecer_no_visor;

        }

        private void btn_1(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num1.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_2(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num2.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_3(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num3.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_4(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num4.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_5(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num5.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_6(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num6.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_7(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num7.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_8(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num8.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void btn_9(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num9.Text;
            visor.Text = para_aparecer_no_visor;
        }

        // AGORA VOU FAZER A FUNCAO DO BOTAO "C" = ZERAR TUDO DO VISOR 

        private void btn_zerar(object sender, EventArgs e)
        {
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_de_calculo_pre_operacao = 0.0;
            memoria_de_calculo_pos_operacao = 0.0;
            operacao = null;

        }

        // CRIANDO A FUNCAO DO BOTAO > "+/-" > ELE TRANSFORMA O NUMERO EM NEGATIVO OU VICEVERSA 

        private void btn_maismenos(object sender, EventArgs e)
        {
            double valor_visor = Convert.ToDouble(visor.Text);

            valor_visor = valor_visor * -1; // isso aqui vai transformar em negativo o numero > QUANDO CLICAR A 1° VEZ > quando clicar a 2° vez > vai trasnformar em positivo > pois ja ta negativo 
            visor.Text = valor_visor.ToString(); 
        }

        // CRIANDO O BOTAO DE PORCENTAGEM 

        private void btn_porcento(object sender, EventArgs e)
        {
            double valor_visor = Convert.ToDouble(visor.Text);

            valor_visor = valor_visor / 100;
            visor.Text = valor_visor.ToString();
        }

        // CRIANDO O BOTAO DO PONTO 

        private void btn_ponto(object sender, EventArgs e)
        {
            para_aparecer_no_visor += ponto.Text;
            visor.Text = para_aparecer_no_visor;
        }
    }

    }

