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
    public partial class Minions : ContentPage
    {
        public Minions()
        {
            InitializeComponent();

            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            poster.Source = ImageSource.FromResource("xamarinFlix.Posters.minions.jpg");

            sinopse.Text = "Seres amarelos milenares, os minions têm uma missão: servir os maiores vilões. Em depressão desde a morte de seu antigo mestre, eles tentam encontrar um novo chefe. Três voluntários, Kevin, Stuart e Bob, vão até uma convenção de vilões nos Estados Unidos e lá se encantam com Scarlet Overkill (Sandra Bullock), que ambiciona ser a primeira mulher a dominar o mundo.";

            var htmlSource = new HtmlWebViewSource
            {
                Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/ly-GueGW3_s' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay;  encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
            };

            visualizador.Source = htmlSource;

        }
    }
}