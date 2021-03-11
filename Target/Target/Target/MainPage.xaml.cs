using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace Target
{
    public partial class MainPage : CarouselPage
    {
        public List<string> Data { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

/*        private IList<string> readInObjects()
        {

            var assembly = this.GetType().GetTypeInfo().Assembly;
            Stream stream =
                   assembly.GetManifestResourceStream("data.json"); // make sure you inset the full 
                                                                    // namespace here, not just the 
                                                                    // name of the file
            using (var reader = new StreamReader(stream))
            {
                var kJson = reader.ReadToEnd();
                return Data = JsonConvert.DeserializeObject<List<string>>(kJson);
            }
    }
*/

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new AddObject();
        }

        private void AddMilestone(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new TargetContent();
        }
        
    }
}
