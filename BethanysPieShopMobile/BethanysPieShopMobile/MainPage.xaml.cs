using System.ComponentModel;
using Xamarin.Forms;

namespace BethanysPieShopMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DemoButton_Clicked(object sender, System.EventArgs e)
        {
            DemoButton.Text = "I was clicked";
        }
    }
}
