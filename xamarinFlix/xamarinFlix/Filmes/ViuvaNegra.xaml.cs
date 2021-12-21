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
    public partial class ViuvaNegra : ContentPage
    {
        public ViuvaNegra()
        {
            InitializeComponent();

            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            poster.Source = ImageSource.FromResource("xamarinFlix.Posters.viuvaNegra.jpg");

            sinopse.Text = "Em Viúva Negra, acompanhamos a vida de Natasha Romanoff (Scarlett Johansson) após os eventos de Guerra Civil. Se escondendo do governo norte-americano devido a sua aliança com o time do Capitão América, Natasha ainda precisa confrontar partes de sua história quando surge uma conspiração perigosa ligada ao seu passado. Perseguida por uma força que não irá parar até derrotá-la, ela terá que lidar com sua antiga vida de espiã, e também reencontrar membros de sua família que deixou para trás antes de se tornar parte dos Vingadores.";

            var htmlSource = new HtmlWebViewSource
            {
                Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/Gm3o0bfGP3g' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
            };

            visualizador.Source = htmlSource;
        }
    }
}