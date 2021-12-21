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
    public partial class Croods : ContentPage
    {
        public Croods()
        {
            InitializeComponent();

            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            poster.Source = ImageSource.FromResource("xamarinFlix.Posters.croods.jpg");

            sinopse.Text = "Em plena era pré-histórica, escondidos na maior parte do tempo dentro de uma caverna, vivem Grug (Nicolas Cage / Hércules Franco), a esposa Ugga (Catherine Keener / Bárbara Monteiro), a vovó (Cloris Leachman / Mariângela Cantú), o garoto Thunk (Clark Duke / Fred Mascarenhas), a pequena e feroz Sandy (Randy Thom / Pâmela Rodrigues) e a jovem Eep (Emma Stone / Luísa Palomanes). Eles são os Croods, uma família liderada por um pai que morre de medo do mundo exterior. Só que grandes transformações estão para acontecer, pois a adolescente Eep acaba conhecendo o também jovem Guy (Ryan Reynolds / Raphael Rossatto) e ele vai apresentar um incrível mundo novo, para o desespero do paizão protetor. Agora, juntos, eles vão enfrentar grandes desafios e se adaptar a uma nova e divertida era.";

            var htmlSource = new HtmlWebViewSource
            {
                Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/3TWjsu5grs4' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay;  encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
            };

            visualizador.Source = htmlSource;
        }
    }
}