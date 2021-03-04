using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
