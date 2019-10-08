using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");

            List<TeamMember> team = new List<TeamMember>();

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


                TeamMember member = new TeamMember();
                member.Name = name;
                member.SkillLevel = int.Parse(skillLevel);
                member.CourageFactor = double.Parse(courageFactor);

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
            foreach (TeamMember member in team)
            {
                teamSkill += member.SkillLevel;
            }

            HeistReport report = new HeistReport();

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
                    report.FailureCount++;
                    Console.WriteLine("---------------");
                }
                else
                {
                    Console.WriteLine("You're Rich!");
                    report.SuccessCount++;
                    Console.WriteLine("---------------");
                }

            }

            report.print();

            

        }
    }
}
