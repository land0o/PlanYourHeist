using System;

namespace PlanYourHeist
{
    public class HeistReport
    {
        public HeistReport()
        {
            SuccessCount = 0;
            FailureCount = 0;
        }
        public int SuccessCount { get; set; }
        public int FailureCount { get; set; }

        public void print()
        {
            Console.WriteLine();
            Console.WriteLine("Heist Results");
            Console.WriteLine("------------");
            Console.WriteLine($"Successes: {this.SuccessCount}");
            Console.WriteLine($"Failures: {this.FailureCount}");
        }
    }
}