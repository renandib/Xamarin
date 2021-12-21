using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapitaoAmerica : ContentPage
    {
        public CapitaoAmerica()
        {
            InitializeComponent();

            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            poster.Source = ImageSource.FromResource("xamarinFlix.Posters.CapitaoAmerica.jpg");

            sinopse.Text = "Steve Rogers é um jovem que participa de experiências visando a criação do supersoldado americano. Quando os oficiais militares conseguem transformá-lo em uma arma humana, eles percebem que não podem arriscar a vida do jovem nas batalhas de guerra.";

            var htmlSource = new HtmlWebViewSource
            {
                Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/-006iHDHK34' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
            };

            visualizador.Source = htmlSource;




            // PAREI AQUI > O VIDEO NAO TA EXIBINDO > E NAO TA CARREGANDO DIREITO OS POSTERS.. FALTA TERMINAR AS OUTRAS PAGINAS
            // VER COM A GALERA SE CONSEGUIU E PEGAR DICAS.. OU TENTAR FAZER NO CEL.. 
            // esse video ensina > https://www.youtube.com/watch?v=gIt4hv501Bc (FUNCIONOU TIVE Q VER ESSE VIDEO)

            // FALTA TERMINAR O RESTANTE > SÓ FIZ O CAPITAO AMERICA.. TENQ TESTAR NO CEL E VER PQ NAO TA CARREGANDO AS PAGINAS 
        }
    }
}