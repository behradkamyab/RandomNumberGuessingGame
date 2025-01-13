namespace RandomNumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(1,100);
            int guess = 0;
            bool isCorrect = false;
            Console.WriteLine("Welcome to the NUMBER GUESSING GAME");
            Console.WriteLine("I'm thinking about a number between 1 to 100");


            while (!isCorrect)
            {
                Console.WriteLine("Guess the number: ");


                if(!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Thats not a number.");
                    continue;
                }

                if (guess < value)
                {
                    Console.WriteLine("No, the number Im thinking is higher than " + guess);
                }
                else if (guess > value) { Console.WriteLine("No. the number im thinking is lower than " + guess); } else
                {
                    isCorrect = true;
                    Console.WriteLine("You guessed right!");
                }
            }

        }
    }
}
