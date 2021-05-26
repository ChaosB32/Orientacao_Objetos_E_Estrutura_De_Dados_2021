using System;

namespace AkinatorFake
{
    class Program
    {
        static Tree gameTree;
        static void Main(string[] args)
        {
            GameSetup();
            Console.WriteLine("Starting the game!!!");
            gameTree.ProcessTree();
            while (PlayAgain())
            {
                Console.Clear();
                gameTree.ProcessTree();
            }
        }

        private static void GameSetup()
        {
            Console.WriteLine("No prior knowledge ...");
            Console.WriteLine("Initializing the game...");
            Console.WriteLine("Submit a question about Resident Evil:");
            string firstQuestion = Console.ReadLine();
            Console.WriteLine("Give a try if the answer is 'yes':");
            string yesAnswer = Console.ReadLine();
            Console.WriteLine("Give a try if the answer is 'no':");
            string noAnswer = Console.ReadLine();
            gameTree = new Tree(firstQuestion, yesAnswer, noAnswer);
        }
        
        static bool PlayAgain()
        {
            Console.WriteLine("Shall we play another game?");
            char userAnswer = char.Parse(Console.ReadLine());
            if(userAnswer == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
