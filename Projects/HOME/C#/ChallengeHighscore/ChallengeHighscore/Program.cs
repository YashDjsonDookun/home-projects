using System;

namespace ChallengeHighscore
{    class Program
    {
        static int highScore = 20;
        static string highScorePlayer = "Foo";
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Input your score: ");
            string scoreInput = Console.ReadLine();

            int score = int.Parse(scoreInput);

            checkForNewHighScore(name, score);
            Console.Read();
        }

        public static void checkForNewHighScore(string x, int y)
        {
            if (y > highScore) {
                highScore = y;
                highScorePlayer = x;
                Console.WriteLine("New highscore is {0}.\nNew highscore holder is {1}.", highScore, highScorePlayer);
            }
            else {
                Console.WriteLine("The old highscore of {0} could not be broken and is still held by {1}.", highScore, highScorePlayer);
            }
        }
    }
}
