using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Target
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TargetContent : ContentPage
    {
        public TargetContent()
        {
            InitializeComponent();
        }
        private void Confirm_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        private void Handle_Focused(object sender, EventArgs e)
        {
            ((Entry)sender).Text = string.Empty;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}