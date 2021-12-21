using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void botao_Calcular (object sender, EventArgs e)
        {
                        
            double peso = Convert.ToDouble(txt_peso.Text); // PEGANDO O PESO DO FRONT E TRASNFORMANDO PRA FLOAT 
            double altura = Convert.ToDouble(txt_altura.Text); // PEGANDO A ALTURA DO FRONT E TRASNFORMANDO PRA FLOAT AQUI 

            double resultado = peso / (altura * altura);  // FAZENDO O CALCULO DO IMC 

            double resultado2 = Math.Round(resultado, 2); // deixando apenas duas casas decimais 

            string mostrar = Convert.ToString(resultado2);            // CONVERTENDO A RESPOSTA PARA STRING 

            resposta.Text = "O valor do imc é de " + mostrar;
            
            if(peso == 0 && altura==0)
            {
                resposta.Text = "POR FAVOR PREENCHA OS CAMPOS !";
            }
            else if(peso == 0 && altura > 0)
            {
                resposta.Text = "Por favor digite um valor para o peso !";
            }
            else if(peso > 0 && altura==0)
            {
                resposta.Text = "Por favor digite um valor para altura !";
            }


            else if(resultado2 > 0 && resultado2 < 18.5)
            {
                resposta.Text = "O valor do IMC é de : " +"[" +mostrar+ "]" + "\n ESTADO DE MAGREZA! ";
            }
            else if(resultado2 >= 18.5 && resultado2 <=24.9 )
            {
                resposta.Text = "O valor do IMC é de : " + "[" + mostrar + "]" + "\n PESO NORMAL ! ";
            }
            else if(resultado2 >=25 && resultado2 <= 29.9)
            {
                resposta.Text = "O valor do IMC é de : " + "[" + mostrar + "]" + "\n ESTADO DE SOBREPESO 1 ! ";
            }
            else if(resultado2 >= 30 && resultado2 <= 39.9)
            {
                resposta.Text = "O valor do IMC é de : " + "[" + mostrar + "]" + "\n OBESIDADE GRAU 2 ";
            }
            else if(resultado2 >= 40)
            {
                resposta.Text = "O valor do IMC é de : " + "[" + mostrar + "]" + "\n OBESIDADE GRAU 3 ";
            }
            
        }
    }
}
