using SpaceExpedition.Interfaces;

namespace SpaceExpedition.Classes
{
    public class Mercury : Planet, IRequireSurvivalTest
    {
        public int PassingScore { get; set; }

        public Mercury(int passingScore)
        {
            Name = "Меркурий";
            PassingScore = passingScore;
        }

        public override string Check(Student student)
        {
            if (!student.SurvivalTests.TryGetValue(this, out int score) || score < PassingScore)
                return $"{student.Name}: Не прошёл тест на выживание.";

            return $"{student.Name}: Готов к миссии!";
        }
    }
}