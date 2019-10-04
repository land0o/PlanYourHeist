using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");

            List<Dictionary<string, string>> team = new List<Dictionary<string, string>>();

            //first team member name
            Console.Write("Name> ");
            string name = Console.ReadLine();

            while (name != "")
            {
                Console.Write("skill Level> ");
                string skillLevel = (Console.ReadLine());

                Console.Write("courage Factor> ");
                string courageFactor = (Console.ReadLine());

                Dictionary<string, string> member = new Dictionary<string, string>() {
                    {"Name", name},
                    {"skillLevel", skillLevel},
                    {"courageFactor", courageFactor}
                };
                team.Add(member);

                //get the 2nd team member name
                Console.Write("Name> ");
                name = Console.ReadLine();

            }

            Console.WriteLine($"Team Size: {team.Count}");
            Console.WriteLine("Team Members");

            foreach (Dictionary<string, string> member in team)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Name: {member["Name"]}");
                Console.WriteLine($"Skill {member["skillLevel"]}");
                Console.WriteLine($"Courage {member["courageFactor"]}");
            };

        }
    }
}
