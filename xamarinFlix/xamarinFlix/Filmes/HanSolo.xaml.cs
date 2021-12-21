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
    public partial class HanSolo : ContentPage
    {
        public HanSolo()
        {
            InitializeComponent();
            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            poster.Source = ImageSource.FromResource("xamarinFlix.Posters.hanSolo.jpg");

            sinopse.Text = "Em dificuldade financeira, o piloto Han Solo (Alden Ehrenreich) e sua namorada Qi'ra (Emilia Clarke) buscam algum trabalho. Eles conseguem pôr as mãos em uma substância valiosa, mas perigosa, que acaba levando à perseguição do Império e à separação entre os dois.";

            var htmlSource = new HtmlWebViewSource
            {
                Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/EQpr5HXTvmg' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay;  encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
            };

            visualizador.Source = htmlSource;

        }
    }
}