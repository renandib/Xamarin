using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarinFlix.Filmes;
using xamarinFlix.Categorias;

namespace xamarinFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class aventura : ContentPage
    {
       // OBS > SÓ VOU FAZER DE 3 CATEGORIAS > AÇÃO , COMEDIA E SUSPENSE > PQ DA MUITO TRABALHO E N TENHO TEMPO
       // É SÓ SEGUIR O PADRAO DE HANSOLO.XAML + HAN SOLO.HAML.CS E ACRESCENTAR AQUI NAS CATEGORIAS AS FUNCOES E AS IMAGENS.. 

        public aventura()
        {
            InitializeComponent();

            
            logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            btnCapitaoAmerica.Source = ImageSource.FromResource("xamarinFlix.Posters.CapitaoAmerica.jpg");

            btnHanSolo.Source = ImageSource.FromResource("xamarinFlix.Posters.hanSolo.jpg");

            btnViuvaNegra.Source = ImageSource.FromResource("xamarinFlix.Posters.viuvaNegra.jpg");

            btnTiraDaPesada.Source = ImageSource.FromResource("xamarinFlix.Posters.tiradaPesada.jpg");

            /*
            btn_007.Source = ImageSource.FromResource("xamarinFlix.Posters.007.jpg");

            btn_linhaDePasse.Source = ImageSource.FromResource("xamarinFlix.Posters.linhadePasse.jpg");
            */
        }

        private void btnCapitaoAmerica_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.CapitaoAmerica());
            }
            catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "ok :( ");
            }
        }

        private void btnHanSolo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.HanSolo());
            }
            catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "ok :( ");
            }
        }

        private void btnViuvaNegra_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.ViuvaNegra());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "ok :( ");
            }
        }
    }
}