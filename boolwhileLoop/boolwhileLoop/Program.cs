using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("What year was I born? Hint: I'm a mid-late millenial.");
        int yearBorn = Convert.ToInt32(Console.ReadLine());
        bool yearGuess = yearBorn == 1989;

        while (!yearGuess)
        switch (yearBorn)
        {
                case 1986:
                    Console.WriteLine("Nope not 1986! Try again :)");
                    Console.WriteLine("What year was I born? Hint: I'm a mid-late millenial.");
                    yearBorn = Convert.ToInt32(Console.ReadLine());
                    break;
                case 1987:
                    Console.WriteLine("Sorry not 1987. Getting close though! Try again :)");
                    Console.WriteLine("What year was I born? Hint: I'm a mid-late millenial.");
                    yearBorn = Convert.ToInt32(Console.ReadLine());
                    break;
                case 1988:
                    Console.WriteLine("Nope! Almost got it!! Try again :)");
                    Console.WriteLine("What year was I born? Hint: I'm a mid-late millenial.");
                    yearBorn = Convert.ToInt32(Console.ReadLine());
                    break;
                case 1989:
                    Console.WriteLine("You got it! I was born in 1989! Ready for all the fun the 90's had to provide! :)");
                    yearGuess = true;
                    break;
                default:
                    Console.WriteLine("That's not it... Try again! :)");
                    Console.WriteLine("What year was I born? Hint: I'm a mid-late millenial.");
                    yearBorn = Convert.ToInt32(Console.ReadLine());
                    break;
        }


        Console.ReadLine();
        }
    }

