using SpaceExpedition.Interfaces;

namespace SpaceExpedition.Classes
{
    public class Jupiter : Planet, IRequireSamples
    {
        public int SampleCount { get; set; }

        public Jupiter(int sampleCount)
        {
            Name = "Юпитер";
            SampleCount = sampleCount;
        }

        public override string Check(Student student)
        {
            if (!student.Samples.TryGetValue(this, out int samples) || samples < SampleCount)
                return $"{student.Name}: Не собрал нужное количество образцов.";

            return $"{student.Name}: Готов к миссии!";
        }
    }
}