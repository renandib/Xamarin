using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AreasGeometricas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Circulo : ContentPage
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void Button_calcular(object sender, EventArgs e)
        {
            try
            {
                double raio = Double.Parse(txt_raio.Text);
                double areaCirculo = 3.14 * (raio * raio);
                resultado.Text = "A área do circulo é de " + areaCirculo.ToString(("0.00"));
                resultado.TextColor = Color.Black;
                resultado.HorizontalTextAlignment = TextAlignment.Center;
            }
            catch (Exception ex)
            {
                resultado.Text = "Houve um erro! \n" + ex.Message;
            }
        }
    }
}
