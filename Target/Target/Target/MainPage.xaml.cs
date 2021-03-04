using Xamarin.Forms;

namespace Target
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void readInObjects()
        {

        }
        private void loadInObjects()
        {

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new AddObject();
        }

        
    }
}
