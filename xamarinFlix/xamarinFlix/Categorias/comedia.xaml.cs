using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class comedia : ContentPage
    {
        public comedia()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            btnIncriveis.Source = ImageSource.FromResource("xamarinFlix.Posters.incriveis.jpg");

            btnGenteGrande.Source = ImageSource.FromResource("xamarinFlix.Posters.genteGrande.jpg");

            btnMinions.Source = ImageSource.FromResource("xamarinFlix.Posters.minions.jpg");

            btnCroods.Source = ImageSource.FromResource("xamarinFlix.Posters.croods.jpg");

            /*
            btn_007.Source = ImageSource.FromResource("xamarinFlix.Posters.007.jpg");

            btn_linhaDePasse.Source = ImageSource.FromResource("xamarinFlix.Posters.linhadePasse.jpg");
            */
        }

        private void btnIncriveis_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.incriveis());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "ok :( ");
            }
        }

        private void btnGenteGrande_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.genteGrande());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "ok :( ");
            }
        }

        private void btnMinions_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Minions());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "ok :( ");
            }
        }

        private void btnCroods_Clicked (object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Croods());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "ok :(");
            }
        }
    }
}
