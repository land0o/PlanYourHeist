﻿using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");

            List<Dictionary<string, string>> team = new List<Dictionary<string, string>>();

            Console.Write("bank Difficulty> ");

            int bankDifficulty = int.Parse(Console.ReadLine());


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

                Console.WriteLine();

                //get the 2nd team member name
                Console.Write("Name> ");
                name = Console.ReadLine();

            }

            Console.WriteLine();
            Console.Write("Number of trail runs>");
            int trailRunsCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // Console.WriteLine($"Team Size: {team.Count}");



            int teamSkill = 0;
            foreach (Dictionary<string, string> member in team)
            {
                string skillLevel = member["skillLevel"];
                teamSkill = teamSkill + int.Parse(skillLevel);
            }

            Dictionary<string, int> report = new Dictionary<string, int>() {
                {"Success", 0},
                {"Failure", 0}
            };

            for (int i = 0; i < trailRunsCount; i++)
            {

                Random generator = new Random();
                int luckValue = generator.Next(-10, 11);

                int trailRunBankDiffuiculty = bankDifficulty += luckValue;


                Console.WriteLine($"Team skill level: {teamSkill}");
                Console.WriteLine($"Bank difficulty: {trailRunBankDiffuiculty}");


                if (bankDifficulty > teamSkill)
                {
                    Console.WriteLine("Your heist has been impeded, run and never look back!");
                    int failures = report["Failure"];
                    report["Failure"] = failures + 1;
                    Console.WriteLine("---------------");
                }
                else
                {
                    Console.WriteLine("You're Rich!");
                    int success = report["Success"];
                    report["Success"] = success + 1;
                    Console.WriteLine("---------------");
                }

            }

            Console.WriteLine();
            Console.WriteLine("Heist Results");
            Console.WriteLine("------------");
            Console.WriteLine($"Successes: {report["Success"]}");
            Console.WriteLine($"Failures: {report["Failure"]}");

        }
    }
}
