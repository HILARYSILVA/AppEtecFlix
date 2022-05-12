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
    public partial class Romance : ContentPage
    {
        public Romance()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_romance.png");
            PorLugaresIncriveis.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Romance.lugares_incriveis.jpg");
        }

        private void btnPorLugaresIncriveis_Clicked(object sender, EventArgs e)
        {

        }
    }
}