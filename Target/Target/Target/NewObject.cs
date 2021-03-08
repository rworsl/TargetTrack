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
            saveToFileAsync();
        }

        private async System.Threading.Tasks.Task saveToFileAsync()
        {
            List<string> _data = new List<string>();
            _data.Add(Name);
            _data.Add(Target.ToString());
            _data.Add(Saved.ToString());

            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Targets.txt");
            using (var writer = File.CreateText(backingFile))
            {
                string json = JsonConvert.SerializeObject(_data.ToArray(), Formatting.Indented);
                await writer.WriteLineAsync(json);
            }
            if (File.Exists(backingFile))
            {
                Console.WriteLine("The file location is: " + backingFile.ToString());
            }
        }
    }
}
