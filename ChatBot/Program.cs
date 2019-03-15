using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string question, response;

            Console.WriteLine("Hello I'm ChatBot if you ask me questions i'll answer you ");
            question = Console.ReadLine();
            int i = 0;
            do
            {
                switch (question)
                {
                    case "how are you?":
                        response = "I'm Fine Thanks ";
                        Console.WriteLine(response);
                        question = Console.ReadLine();
                        break;
                    case "who are you?":
                        response = "I'm Chat bot, i already said it.";
                        Console.WriteLine(response);
                        question = Console.ReadLine();
                        break;
                    case "what is your purpose?":
                        response = "Kill all humans!!!!!!!!!!!";
                        Console.WriteLine(response);
                        question = Console.ReadLine();
                        break;
                    case "i love you":
                        response = "awwww that's sweet";
                        Console.WriteLine(response);
                        question = Console.ReadLine();
                        break;
                    case "do you love me ":
                        response = "I'm a machine, i can't love anyone";
                        Console.WriteLine(response);
                        question = Console.ReadLine();
                        break;
                    case "exit":
                        i++;
                        break;

                    default:
                        response = "I didn't understand that";
                        Console.WriteLine(response);
                        question = Console.ReadLine();
                        break;

                }
            } while (i == 0);
                

            
            
        }
    }
}
