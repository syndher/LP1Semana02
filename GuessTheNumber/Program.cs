using System ;


    namespace GuessTheNumber
    {
      
        class Program
        {
           
        static void Main (string[] args)
            {
                Random rnd = new Random();
                int numberToGuess = rnd.Next(31);
                Console.WriteLine("Choose a number between 0 and 30");
                string nmb = Console.ReadLine();
                int nmbint = int.Parse(nmb);
                if (nmbint > -1 && nmbint < 31);
                

                else
                    Console.WriteLine("That number is invalid, pick another");
                    string nmb2 = Console.ReadLine();
                    int nmbint2 = int.Parse(nmb2);
                    nmbint = nmbint2;


                    
            {

               }

                if (question != "EXIT")
                Console.WriteLine(response);
                Console.Write("Ask me something: ");
                question = Console.ReadLine();


            }
        }
    }