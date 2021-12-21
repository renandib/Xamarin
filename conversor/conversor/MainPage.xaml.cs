using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/// <summary>
/// AQUI É O MEU BACK > AQUI EU FAÇO AS CHAMADAS DE TODOS OS COMPONENTES Q EU CRIEI NA "MAINPAGE.XAML" = FRONT 
/// PRA FAZER COMENTARIOS AQUI É SÓ COLOCAR >/// AI ELE ADD UM "SUMARY > E EU POSSO COMENTAR O QUE QUISER" 
/// </summary>
/// DPS DE "INITIALIZE COMPONENTE > EU VOU CRIAR MINHAS FUNÇÕES OU MÉTODOS PRA CHAMAR MEUS COMPONENTES 

namespace conversor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Botao_Conversao(object sender, EventArgs e)
        {
            try      // É SEMPRE BOM FAZER UM TRY CACTH > COMO TRATAMENTO DE ERRO > SE ALGO DER ERRADO 
            {
                decimal real = Convert.ToDecimal(txt_real.Text);    // CONVERTENDO PARA DECIMAL > E CHAMANDO A VARIAVEL Q EU CRIEI NO "ENTITY" > LA NO FRONT
                decimal dolar = Convert.ToDecimal(txt_dolar.Text);

                decimal convertido = real * dolar;  // FAZENDO A CONTA DE CONVERSÃO 

                NumberFormatInfo nfi = new CultureInfo("pt-br").NumberFormat;   // AQUI EU TO CRIANDO UM OBJETO > "NFI" E TRAZENDO A CLASSE NUMBERINFO.. > PARA TRAZER ELA PRECISA INSTANCIAR ESSE NEW CULTURE.. > ISSO VAI FAZER COM Q O PADRAO DE MOEDA SE TORNE BRASILEIRO E NAO AMERICANO
                                                                                // trazendo essa classe tbm precisa importar ela > só clicar encima e apertar > "alt + enter"
                                                                                // > para transformar o padrao das virgulas no padrao brasileiro 

                txt_valorreais.Text = convertido.ToString("C", nfi); // PEGANDO O VALOR DA VARIAVEL RESPOSTA FINAL E TRANSFORMANDO A CONTA EM STRING > (STRING , OBJETO Q EU CRIEI ACIMA )
                                                                     // LEMBRANDO Q ESSE "C" É O QUE TRANSFORMA PARA "REAIS" ATRAVES DA CLASSE ACIMA > "CULTURE.."
            }
            catch (Exception ex)
            {
                txt_valorreais.Text = "Ocorreu um erro! \n " + ex.Message; // SE CASO NAO ACONTECER O DE CIMA VAI EXIBIR ESSA MENSAGEM 
            }

        }
    }
}
