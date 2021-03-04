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

        private void createGoal()
        {
            var name = GName.Text;
            var target = Int32.Parse(GTarget.Text);
            new NewObject(name, target, 0);
        }

        private void Confirm_Clicked(object sender, EventArgs e)
        {
            createGoal();
            App.Current.MainPage = new MainPage();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}