using System;
using System.Collections.Generic;
using SpaceExpedition.Classes;
using SpaceExpedition.Interfaces;

namespace SpaceExpedition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>()
            {
                new Mars(5, 70),
                new Venus(),
                new Mercury(80),
                new Jupiter(7)
            };

            Student student1 = new Student("Иван Космонавтов");
            student1.Samples.Add(planets[0], 5);
            student1.Samples.Add(planets[3], 7);
            student1.SurvivalTests.Add(planets[0], 85);
            student1.SurvivalTests.Add(planets[2], 90);

            Student student2 = new Student("Анна Звёздная");
            student2.Samples.Add(planets[0], 3);
            student2.Samples.Add(planets[3], 8);
            student2.SurvivalTests.Add(planets[0], 60);
            student2.SurvivalTests.Add(planets[2], 70);

            Student student3 = new Student("Кирилл Галактионов");
            student3.Samples.Add(planets[0], 6);
            student3.Samples.Add(planets[3], 5);
            student3.SurvivalTests.Add(planets[0], 80);
            student3.SurvivalTests.Add(planets[2], 85);

            List<Student> students = new List<Student>() { student1, student2, student3 };

            foreach (var planet in planets)
            {
                Console.WriteLine();
                Console.WriteLine(planet.Name);
                Console.WriteLine("=========");

                if (planet is IHaveAngryResidents)
                {
                    Console.WriteLine("На этой планете живут агрессивные жители, миссия невозможна!");
                    continue;
                }

                foreach (var student in students)
                {
                    Console.WriteLine(planet.Check(student));
                }
            }

            Console.ReadKey();
        }
    }
}