using System;
using System.Threading;

class Quiz
{
    static void Main()
    {
        game();
        Console.ReadLine();
    }

    static void game()
    {
        int score = 0;

        Console.WriteLine("\n===========================================");
        Console.WriteLine(" Welcome to the Tank Quiz!");
        Console.WriteLine("===========================================\n");
        shortPause();
        Console.WriteLine("You will be answering a few questions.");
        Console.WriteLine("Please select an option by typing a, b, or c.\n");
        middleLongPause();

        Console.Write("What is your name? ");
        string? name = Console.ReadLine()?.Trim();

        if (name == "gaster")
        {
            bogosort();
        }

        Console.WriteLine($"\nAlright {name}, let's get started!\n");
        middleLongPause();

        firstQuestion(ref score);
        secondQ(ref score);
        thirdQ(ref score);
        fourthQ(ref score);
        finalQ(ref score);

        Console.WriteLine($"\nCongratulations, {name}! Your final score is: {score}/6");
    }

    static void firstQuestion(ref int score)
    {
        Console.WriteLine("What was the first-ever tank used in combat?");
        Console.WriteLine("a) The Mark I");
        Console.WriteLine("b) T-54");
        Console.WriteLine("c) M48 Patton");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "a")
        {
            score += 1;
            Console.WriteLine("\nGreat work! It is indeed the Mark I, used by the British Army during World War I in 1916.");
        }
        else if (answer == "b")
        {
            Console.WriteLine("\nNo, the T-54 was created in 1947. The Mark I was created in 1916.");
        }
        else if (answer == "c")
        {
            Console.WriteLine("\nNo, the M48 Patton was created in 1952. The Mark I was created in 1916.");
        }
        else
        {
            Error();
        }
    }

    static void secondQ(ref int score)
    {
        middleLongPause();
        Console.WriteLine("Alright, next question:");
        middleLongPause();
        Console.WriteLine("Which of the following tanks was famously used by the British during World War 2? (Hint: It is known for its resilience)");
        Console.WriteLine("a) Panther Tank");
        Console.WriteLine("b) T-34");
        Console.WriteLine("c) Churchill Tank");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "a")
        {
            Console.WriteLine("\nNo, it is not the German Panther Tank; the right answer was the Churchill Tank.");
        }
        else if (answer == "b")
        {
            Console.WriteLine("\nNo, it is not the Russian T-34; the right answer was the Churchill Tank.");
        }
        else if (answer == "c")
        {
            Console.WriteLine("\nCorrect! The Churchill Tank was indeed famously used by the British during World War 2.");
            score += 1;
        }
        else
        {
            Error();
        }
    }

    static void thirdQ(ref int score)
    {
        middleLongPause();
        Console.WriteLine("Alright, onto the third question:");
        middleLongPause();
        Console.WriteLine("Which of the following tanks is the fastest?");
        Console.WriteLine("a) Challenger 2");
        Console.WriteLine("b) Leopard 2A7");
        Console.WriteLine("c) M1 Abrams");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "a")
        {
            Console.WriteLine("\nNo, it is not the Challenger 2. It has a maximum speed of approximately 59 km/h; the right answer was the Leopard 2A7 (72 km/h).");
        }
        else if (answer == "b")
        {
            Console.WriteLine("\nCorrect! The fastest is indeed the German Leopard 2A7 with a maximum speed of approximately 72 km/h.");
            score += 1;
        }
        else if (answer == "c")
        {
            Console.WriteLine("\nNo, it is not the M1 Abrams. It has a maximum speed of approximately 67 km/h; the right answer was the Leopard 2A7 (72 km/h).");
        }
        else
        {
            Error();
        }
    }

    static void fourthQ(ref int score)
    {
        middleLongPause();
        Console.WriteLine("Only two questions left! To the fourth one:");
        middleLongPause();
        Console.WriteLine("What is the biggest tank?");
        Console.WriteLine("a) T95");
        Console.WriteLine("b) Char B1");
        Console.WriteLine("c) Panzer VIII Maus");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "a")
        {
            Console.WriteLine("\nNo, it is not the T95 (T28 Super Heavy Tank). It has a size of Approximately 95 tons; the right answer was the Panzer VIII Maus (188 tons).");
        }
        else if (answer == "b")
        {
            Console.WriteLine("\nNo, it is not the Char B1. It has a size of Approximately 35 tons; the right answer was the Panzer VIII Maus (188 tons).");
        }
        else if (answer == "c")
        {
            string RelaxItsCalledDarkHumour = "almost as heavy as your mother";
            Console.WriteLine($"\nCorrect! It is indeed the Panzer VIII Maus with a size of 188 tons {RelaxItsCalledDarkHumour}");
            score++;

            Thread.Sleep(1);

            Console.CursorTop--;
            Console.CursorLeft = 0;
            Console.Write(new string(' ', Console.WindowWidth));
            Console.CursorLeft = 0;
            Console.Write($"Correct! It is indeed the Panzer VIII Maus with a size of 188 tons.");
        }

        else
        {
            Error();
        }
    }

    static void finalQ(ref int score)
    {
        middleLongPause();
        Console.WriteLine("Alright and for the final question... (this one is worth 2 points)");
        middleLongPause();
        Console.WriteLine("Which tank was the first to enter service in World War II?");
        Console.WriteLine("a) T-34");
        Console.WriteLine("b) Panzer III");
        Console.WriteLine("c) Matilda II");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "a")
        {
            Console.WriteLine("\nNo, the T-34 entered service in 1940. The right answer was the Panzer III (1937).");
        }
        else if (answer == "b")
        {
            Console.WriteLine("\nCorrect! The Panzer III was among the first tanks to see service in World War II.");
            score += 5;
        }
        else if (answer == "c")
        {
            Console.WriteLine("\nNo, the Matilda II was introduced later. The right answer was the Panzer III (1937).");
        }
        else
        {
            Error();
        }
    }

    static void Error()
    {
        Console.WriteLine("\n======================================");
        Console.WriteLine(" Invalid Input Detected!");
        Console.WriteLine(" Please only pick one of the options: a, b, or c.");
        Console.WriteLine("======================================\n");
        middleLongPause();
        Console.WriteLine("The game will restart.");
        longPause();
        Console.Clear();
        game();
    }

    static void shortPause()
    {
        Thread.Sleep(1000);
    }

    static void middleLongPause()
    {
        Thread.Sleep(2000);
    }

    static void longPause()
    {
        Thread.Sleep(3000);
    }

    static void bogosort()
    {
        List<int> numbers = new List<int>();
        Random rnd = new Random();

        int iteration = 0;
        bool isSorted = false;

        for (int i = 0; i < 5; i++)
        {
            numbers.Add(rnd.Next(0, 101));
        }

        numbers.Add(69);

        while (!isSorted)
        {
            iteration++;

            Console.Write($"bogosort iteration {iteration}: ");

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine(); 

            shuffle(numbers); 

            Console.WriteLine("\n"); 
        }

        Console.WriteLine("Sorted!");
    }

    static bool IsSorted(List<int> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] < list[i - 1])
                return false;
        }
        return true;
    }

    static void shuffle(List<int> list)
    {
        Random rnd = new Random();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rnd.Next(0, i + 1);

            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}