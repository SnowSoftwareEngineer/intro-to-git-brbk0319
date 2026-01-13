using GameEnums;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a Difficulty:\n     Easy\n     Medium\n     Hard");

        string difficultyInput = Console.ReadLine();

        if (Enum.TryParse(difficultyInput, true, out GameEnums.GameDifficulty difficultyLevel))
        {
            Console.WriteLine("Select a Class:\n     Warrior\n     Mage\n     Rogue");
            string classInput = Console.ReadLine();
            if (Enum.TryParse(classInput, true, out GameEnums.CharacterClass characterClass))
            {
                Console.WriteLine($"You selected:\n     Difficulty: {difficultyLevel}\n     Character Class: {characterClass}");
                
            }
            else { Console.WriteLine("Ope, watch the cases there buddy."); }
        }
        else
        {
            Console.WriteLine("haha real funny. Try again.");
        }

    }
}