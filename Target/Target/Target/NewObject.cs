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
        }

        private void saveToFile()
        {
            List<string> _data = new List<string>();
            _data.Add(Name);
            _data.Add(Target.ToString()); 
            _data.Add(Saved.ToString());


            string filename = "Targets.txt";

            string json = JsonConvert.SerializeObject(_data.ToArray(), Formatting.Indented);

            //write string to file
            System.IO.File.WriteAllText(Android.App.Application.Context.Assets + filename, json);
        
        
        }
    }
}
