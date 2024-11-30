using SpaceExpedition.Interfaces;

namespace SpaceExpedition.Classes
{
    public abstract class Planet
    {
        public string Name { get; set; }
        public abstract string Check(Student student);
    }
}