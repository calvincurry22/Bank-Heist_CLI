using System;

namespace bank_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Team sugarGliders = new Team();
            while (true)
            {

                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                else
                {

                    int skillLevel = 1;
                    while (true)
                    {
                        Console.WriteLine("Enter skill level");
                        bool success = int.TryParse(Console.ReadLine(), out skillLevel);

                        if (success && skillLevel > 0)
                        {
                            Console.WriteLine($"Skill level set to: {skillLevel}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter an integer.");
                        }
                    }

                    double courageFactor = 1.0;
                    while (true)
                    {
                        Console.WriteLine("Please enter courage factor (0.0 - 2.0)");
                        bool success = double.TryParse(Console.ReadLine(), out courageFactor);
                        if (success && courageFactor > 0 && courageFactor <= 2.0)
                        {
                            Console.WriteLine($"Courage Factor set to: {courageFactor}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Must enter value between 0.0 and 2.0");
                        }
                    }

                    TeamMember member = new TeamMember(name, skillLevel, courageFactor);

                    Console.WriteLine(member);

                    sugarGliders.AddMember(member);
                    Console.WriteLine($"Your team now has {sugarGliders.ShowMemberCount()}");
                }
            }
            if (sugarGliders.ShowMemberCount() > 0)
            {
                Console.WriteLine($"Your team has {sugarGliders.ShowMemberCount()} members.");
            }
            else
            {
                Console.WriteLine("No members on your team");
            }
            int bankDifficultyLevel = 100;

            if (sugarGliders.TotalSkillLevel() >= bankDifficultyLevel)
            {
                System.Console.WriteLine("Success! You've robbed a bank!");
            }
            else
            {
                System.Console.WriteLine("Failure! Get good.");
            }
        }
    }
}