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
    public partial class Trapezio : ContentPage
    {
        public Trapezio()
        {
            InitializeComponent();
        }
        private void Button_calcular(object sender, EventArgs e)
        {
            try
            {
                double baseMaior = Double.Parse(txt_baseMaior.Text);
                double baseMenor = Double.Parse(txt_baseMenor.Text);
                double altura = Double.Parse(txt_altura.Text);


                double areaTrapezio = (baseMaior + baseMenor) * altura / 2;
                resultado.Text = "A área do Trapezio é de " + areaTrapezio.ToString(("0.00"));
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