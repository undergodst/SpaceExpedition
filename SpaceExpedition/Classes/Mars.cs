using SpaceExpedition.Interfaces;

namespace SpaceExpedition.Classes
{
    public class Mars : Planet, IRequireSamples, IRequireSurvivalTest
    {
        public int SampleCount { get; set; }
        public int PassingScore { get; set; }

        public Mars(int sampleCount, int passingScore)
        {
            Name = "Марс";
            SampleCount = sampleCount;
            PassingScore = passingScore;
        }

        public override string Check(Student student)
        {
            if (!student.Samples.TryGetValue(this, out int samples) || samples < SampleCount)
                return $"{student.Name}: Не собрал нужное количество образцов.";

            if (!student.SurvivalTests.TryGetValue(this, out int score) || score < PassingScore)
                return $"{student.Name}: Не прошёл тест на выживание.";

            return $"{student.Name}: Готов к миссии!";
        }
    }
}