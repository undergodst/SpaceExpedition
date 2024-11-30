using SpaceExpedition.Interfaces;

namespace SpaceExpedition.Classes
{
    public class Venus : Planet, IHaveAngryResidents
    {
        public Venus()
        {
            Name = "Венера";
        }

        public override string Check(Student student)
        {
            return $"{student.Name}: Миссия невозможна из-за агрессивных жителей.";
        }
    }
}