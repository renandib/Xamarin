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
    public partial class incriveis : ContentPage
    {
        public incriveis()
        {
            InitializeComponent();

            //logo.Source = ImageSource.FromResource("xamarinFlix.Imagens.xamarin.png");

            poster.Source = ImageSource.FromResource("xamarinFlix.Posters.incriveis.jpg");

            sinopse.Text = "Roberto Pêra (Craig T. Nelson) já foi o maior herói do planeta, salvando vidas e combatendo o mal todos os dias sob o codinome Sr. Incrível. Porém, após salvar um homem de se suicidar, ele é processado e condenado na Justiça. Uma série de processos seguintes faz com que o Governo tenha que desembolsar uma alta quantia para pagar as indenizações, o que faz com que a opinião pública se volte contra os super-heróis. Em reconhecimento aos serviços prestados, o Governo faz a eles uma oferta: que levem suas vidas como pessoas normais, sem demonstrar que possuem superpoderes, recebendo em troca uma pensão anual. Quinze anos depois, Roberto leva uma vida pacata ao lado de sua esposa Helen (Holly Hunter), que foi a super-heroína Mulher-Elástica, e seus três filhos. Roberto agora trabalha em uma seguradora e luta para combater o tédio da vida de casado e o peso extra. Com vontade de retomar a vida de herói, ele tem a grande chance quando surge um comunicado misterioso, que o convida para uma missão secreta em uma ilha remota.";

            var htmlSource = new HtmlWebViewSource
            {
                Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/iqKEnKRDkds' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay;  encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
            };

            visualizador.Source = htmlSource;

        }
    }
}