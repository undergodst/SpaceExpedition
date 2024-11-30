using System.Collections.Generic;

namespace SpaceExpedition.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public Dictionary<Planet, int> Samples { get; set; }
        public Dictionary<Planet, int> SurvivalTests { get; set; }

        public Student(string name)
        {
            Name = name;
            Samples = new Dictionary<Planet, int>();
            SurvivalTests = new Dictionary<Planet, int>();
        }
    }
}