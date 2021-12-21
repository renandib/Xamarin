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
    public partial class Losango : ContentPage
    {
        public Losango()
        {
            InitializeComponent();
        }
        private void Button_calcular(object sender, EventArgs e)
        {
            try
            {
                double diagonalD = Double.Parse(txt_diagonal1.Text);
                double diagonald = Double.Parse(txt_diagonal2.Text);
                double areaLosango = diagonalD * diagonald / 2;
                resultado.Text = "A área do losango é de " + areaLosango.ToString(("0.00"));
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