namespace c# game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rdn = new Random();
            int secretNumber = rdn.Next(1, 1000);
            int guess = 0;

            while (guess != secretNumber)
            {
                Console.Write("guess");
                guess = int.Parse(Console.ReadLine());

                if (guess < secretNumber)
                {
                    Console.WriteLine("too low");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("too hight");
                }
                else
                {
                    Console.WriteLine("correct you find the number");
                }

            }


        }

    }

}

  
