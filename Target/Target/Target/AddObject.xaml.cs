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
    public partial class AddObject : ContentPage
    {
        public AddObject()
        {
            InitializeComponent();
        }

        private async void Confirm_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}