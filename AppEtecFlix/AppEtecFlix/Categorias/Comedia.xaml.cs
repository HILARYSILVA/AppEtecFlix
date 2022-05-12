using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_comedia.png");
            btnTrocando.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.trocando.jpg");
        }

        private void btnGente_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEsposa_Clicked(object sender, EventArgs e)
        {

        }

        private void btnJuntos_Clicked(object sender, EventArgs e)
        {

        }

        private void btnGente2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnClick_Clicked(object sender, EventArgs e)
        {

        }

        private void btnGemea_Clicked(object sender, EventArgs e)
        {

        }

        private void btnTrocando_Clicked(object sender, EventArgs e)
        {

        }

        private void btnHeranca_Clicked(object sender, EventArgs e)
        {

        }
    }
}