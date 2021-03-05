using System;
using System.IO;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;

namespace Target
{
    class NewObject
    {
        string Name { get; set; }
        int Target { get; set; }
        int Saved { get; set; }

        public NewObject(string GoalName, int GoalTarget, int GoalSaved)
        {
            Name = GoalName;
            Target = GoalTarget;
            Saved = GoalSaved;
            saveToFile();
        }

        private void saveToFile()
        {
            var stream = Application.Current.Resources. .Context.Assets.Open("wordList.txt");
            List<string> _data = new List<string>();
            _data.Add(Name);
            _data.Add(Target.ToString()); 
            _data.Add(Saved.ToString());


            string filename = "Targets.txt";

            var sdCardPath = Android.OS.Environment.ExternalStorageDirectory.Path;
            var fileAddress = System.IO.Path.Combine(sdCardPath, "iootext.txt");

            //string fileAddress = Application.Current.Resources + "." + filename;
            string json = JsonConvert.SerializeObject(_data.ToArray(), Formatting.Indented);

            //write string to file
            System.IO.File.WriteAllText(fileAddress, json);
        
        
        }
    }
}
