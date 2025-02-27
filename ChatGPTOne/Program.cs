using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
  
            // Variables
            string question;
            string response;

            // Asks the user for a question
            Console.Write("Ask me something: ");
            question = Console.ReadLine();

                    switch (question)
                {
                    case "Who are you?":
                        response = "ChatGPTOne";
                        break;
                    case "What are you?":
                        response = "I'm a script";
                        break;
                    case "What is your purpose?":
                        response = "Answer to questions";
                        break;
                    case "Are you alive":
                        response = "I wish";
                        break;
                    case "EXIT":
                        response = "Bye";
                        break;
                    default:
                        response = "I can't answer that";
                        break;
               }

                
                Console.WriteLine(response);
        }   
    }
}
