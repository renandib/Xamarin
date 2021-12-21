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
    public partial class Triangulo : ContentPage
    {
        public Triangulo()
        {
            InitializeComponent();
        }
        private void Button_calcular(object sender, EventArgs e)
        {
            try
            {
                double baset = Double.Parse(txt_base.Text);
                double altura = Double.Parse(txt_altura.Text);
                double areaTriangulo = (baset * altura) / 2;
                resultado.Text = "A área do triangulo é de " + areaTriangulo.ToString(("0.00"));
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