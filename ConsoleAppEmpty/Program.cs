using GameEnums;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a Difficulty:\nEasy\nMedium\nHard");

        string difficultyInput = Console.ReadLine();

        if (Enum.TryParse(difficultyInput, true, out GameEnums.GameDifficulty difficultyLevel))
        {
            Console.WriteLine("Select a Class:\nWarrior\nMage\nRogue");
            string classInput = Console.ReadLine();
            if (Enum.TryParse(classInput, true, out GameEnums.CharacterClass characterClass))
            {
                Console.WriteLine($"You selected:\nDifficulty: {difficultyLevel}\nCharacter Class: {characterClass}");
                
            }
            else { Console.WriteLine("Ope, watch the cases there buddy."); }
        }
        else
        {
            Console.WriteLine("haha real funny. Try again.");
        }

    }
}