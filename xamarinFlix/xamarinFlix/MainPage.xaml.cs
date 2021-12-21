using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamarinFlix.Categorias;

namespace xamarinFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.miniosCapa.jpg");

            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.minios.gif");

            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.minios.gif");
            
            

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok :( ");
            }
        }

        private void Button_Clicked2 (object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new comedia());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok :( ");
            }
        }
    }
}
