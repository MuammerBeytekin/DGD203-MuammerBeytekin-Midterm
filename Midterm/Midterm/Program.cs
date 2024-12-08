using System;

class MidtermGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Maze!");
        Console.Write("What is your name, player? ");
        string playerName = Console.ReadLine();

        Console.WriteLine($"Hello, {playerName}! Maze is starting, let's get ready!");
        Console.WriteLine("In the Maze Game, you always have 3 different choices.");
        Console.WriteLine("You need to choose one of them. Be careful; all paths lead to different outcomes!");

        /////////////////////////////////////////////////////////////////////////

        Console.WriteLine("You have 3 paths in front of you! Which one do you choose?");
        Console.WriteLine("A) A path that looks safer");
        Console.WriteLine("B) A path that looks dangerous");
        Console.WriteLine("C) A path that looks dark");
        string path1 = GetAnswer("A", "B", "C");

        ///////////////////////////////////////////////////////////////////////
        string path2;
        if (path1 == "A")
        {
            Console.WriteLine("You encounter a man on your way!");
            Console.WriteLine("A) Kill the man and keep exploring!");
            Console.WriteLine("B) Talk to the man in a polite way.");
            Console.WriteLine("C) Talk to the man in a rude way.");
            path2 = GetAnswer("A", "B", "C");
        }
        else if (path1 == "C")
        {
            Console.WriteLine("You see a cave.");
            Console.WriteLine("A) Explore the cave.");
            Console.WriteLine("B) Don't go in, take a different path.");
            Console.WriteLine("C) Go around the cave.");
            path2 = GetAnswer("A", "B", "C");
        }
        else
        {
            Console.WriteLine("You are on the edge of a cliff.");
            Console.WriteLine("A) Tie a rope to a stone on the edge of the cliff and go down.");
            Console.WriteLine("B) Slide down cautiously.");
            Console.WriteLine("C) Take another path.");
            path2 = GetAnswer("A", "B", "C");
        }
        ////////////////////////////////////////////////////////////////////////

        Console.WriteLine("You found a treasure, but there's a riddle on it:\nWhich is the best programming language?");
        Console.WriteLine("A) Python");
        Console.WriteLine("B) C#");
        Console.WriteLine("C) Java");
        string path3 = GetAnswer("A", "B", "C");

        //////////////////////////////////////////////////////////////////////////

        Console.WriteLine("Inside the treasure, you find a map leading to 3 different paths.");
        Console.WriteLine("A) Left");
        Console.WriteLine("B) Middle");
        Console.WriteLine("C) Right");
        string path4 = GetAnswer("A", "B", "C");

        ////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("You are at the end of the Maze. There’s something on a log, but you can’t see what it is.\nWhat would you use?");
        Console.WriteLine("A) Pickaxe");
        Console.WriteLine("B) Torch");
        Console.WriteLine("C) Sword");
        string path5 = GetAnswer("A", "B", "C");

        ////////////////////////////////////////////////////////////////////////////
        //I get a little help in there to from GPT cause it has so many possibility.
        //I had GPT organize the probabilities and wrote the texts and logic myself.
        Console.WriteLine($"\nThank you for playing, {playerName}! Based on your choices, here is who you are:");

        if (path1 == "B" && path2 == "A" && path5 == "A")
        {
            Console.WriteLine("You are fearless! Danger and risk excites you. You enjoy taking challenges that others avoid!");
        }
        else if (path1 == "A" && path2 == "B" && path3 == "B")
        {
            Console.WriteLine("You are calm and wise. Politeness and safety are your key values. You always keep your head cool.");
        }
        else if (path2 == "C" && path4 == "C" && path5 == "C")
        {
            Console.WriteLine("You are careful and prefer not to rush things. Thinking twice before acting is what makes you strong.");
        }
        else if (path1 == "C" && path3 == "A" && path4 == "A")
        {
            Console.WriteLine("You are someone curious, unafraid to explore the unknown. Mystery excites you!");
        }
        else if (path1 == "A" && path5 == "B")
        {
            Console.WriteLine("You look for clarity and guidance in your life. A torch symbolizes your desire to see things clearly.");
        }
        else if (path1 == "C" && path2 == "A" && path4 == "B")
        {
            Console.WriteLine("You are bold, but not reckless. While you take risks, you do so with caution and a clear plan.");
        }
        else if (path2 == "B" && path3 == "C" && path5 == "A")
        {
            Console.WriteLine("You value logic and strategy above all. Your decisions are well-thought and never random.");
        }
        else if (path1 == "B" && path3 == "B" && path4 == "C")
        {
            Console.WriteLine("You are creative and daring. You see things differently and love finding unique ways out of situations.");
        }
        else if (path2 == "A" && path4 == "B" && path5 == "C")
        {
            Console.WriteLine("You are like a warrior! Your strength and determination stand out in every situation.");
        }
        else
        {
            Console.WriteLine("You are adaptable and balanced, a true survivor in any situation. Nothing fazes you for long!");
        }

        Console.WriteLine($"Game is finished! Hope you enjoyed {playerName}!");


        // This a GPT part but i understand what is what.
        static string GetAnswer(params string[] validOptions)
        {
            string input;
            do
            {
                Console.Write("Your choice: ");
                input = Console.ReadLine().ToUpper();

                if (Array.Exists(validOptions, option => option == input))
                    break;

                Console.WriteLine("Invalid choice, please select a valid option!");
            } while (true);

            return input;
        }
    }
}
