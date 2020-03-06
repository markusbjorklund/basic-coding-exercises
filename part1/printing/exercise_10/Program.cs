using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            string characterName = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string characterProfession = Console.ReadLine();
            Console.WriteLine("Here is the story:" + "\n" +
            "Once upon a time there was a " + characterProfession + " called " + characterName + "\n" +
            "On her way to work, " + characterName + " often pondered what being " + characterProfession + " meant to them." + "\n" +
            "When you work as a " + characterProfession + " you meet interesting people." + "\n" +
            characterName + " enjoys their work as " + characterProfession + ", The end."
            );
        }
    }
}
