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
    public partial class Quadrado : ContentPage
    {
        public Quadrado()
        {
            InitializeComponent();
        }
        private void Button_calcular(object sender, EventArgs e)
        {
            try
            {
                double lado = Double.Parse(txt_lado.Text);
                double areaQuadrado = lado * lado;
                resultado.Text = "A área do quadrado é de " + areaQuadrado.ToString(("0.00"));
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