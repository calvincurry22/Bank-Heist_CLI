using System;

namespace bank_heist {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Plan your heist!");

            Console.WriteLine ("Enter name");
            string name = Console.ReadLine ();

            int skillLevel = 1;
            while (true) {
                Console.WriteLine ("Enter skill level");
                bool success = int.TryParse (Console.ReadLine (), out skillLevel);

                if (success && skillLevel > 0) {
                    Console.WriteLine ($"Skill level set to: {skillLevel}");
                    break;
                } else {
                    Console.WriteLine ("Please enter an integer.");
                }
            }

            double courageFactor = 1.0;
            while (true) {
                Console.WriteLine ("Please enter courage factor (0.0 - 2.0)");
                bool success = double.TryParse (Console.ReadLine (), out courageFactor);
                if (success && courageFactor > 0 && courageFactor < 2.0) {
                    Console.WriteLine ($"Courage Factor set to: {courageFactor}");
                    break;
                } else {
                    Console.WriteLine ("Must enter value between 0.0 and 2.0");
                }
            }

            TeamMember One = new TeamMember (name, skillLevel, courageFactor);

            Console.WriteLine (One);

        }
    }
}