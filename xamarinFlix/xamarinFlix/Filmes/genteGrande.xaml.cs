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
    public partial class genteGrande : ContentPage
    {
        public genteGrande()
        {
            InitializeComponent();

            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            poster.Source = ImageSource.FromResource("xamarinFlix.Posters.genteGrande.jpg");

            sinopse.Text = "Em Gente Grande, Lenny (Adam Sandler), Kurt (Chris Rock), Eric (Kevin James), Marcus (David Spade) e Rob (Rob Schneider) se conhecem desde pequenos. Passados trinta anos, os cinco amigos se reencontram para curtir um fim de semana juntos com as respectivas famílias, mas o feriado de 4 de Julho em uma casa no lago promete muito mais diversão do que apenas lembranças dos bons momentos. Casados e com várias crianças, os homens de família terão de confrontar o fato de não serem mais tão jovens.";

            var htmlSource = new HtmlWebViewSource
            {
                Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/wGyjbrMC-Ok' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay;  encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
            };

            visualizador.Source = htmlSource;

        }
    }
}