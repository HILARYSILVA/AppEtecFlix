using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppEtecFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_etecflix.png");

            
        }       
        private void btnComedia_Clicked(object sender, EventArgs e)
        {
            try
            {

                Navigation.PushAsync(new Categorias.Comedia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnRomance_Clicked(object sender, EventArgs e)
        {
            try
            {

                Navigation.PushAsync(new Categorias.Romance());

            }catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
