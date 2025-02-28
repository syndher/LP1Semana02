using System ;
using System.Formats.Asn1;


namespace GuessTheNumber
    {
      
        class Program
        {
           
        static void Main (string[] args)
            {
                Random rnd = new Random();
                int numberToGuess = rnd.Next(31);
                Console.WriteLine("Insert Number");

                int attempts = 0;
                bool guess = false;
                while (guess == false)
                {
                    string nmb = Console.ReadLine();
                    int nmbint = int.Parse(nmb);
                if (nmbint > -1 && nmbint < 31)
                {
                    if (numberToGuess > nmbint)
                    {
                        Console.WriteLine($"The hidden number is higher than {nmbint}. Try again.");
                        attempts = attempts + 1;
                    }

                    else if (numberToGuess < nmbint)
                    {
                        Console.WriteLine($"The hidden number is lower than {nmbint}. Try again.");
                        attempts = attempts + 1;
                    }
                        

                    else if (numberToGuess == nmbint)                     
                        Console.WriteLine($"You took {attempts} attempts!");
                        guess = true;
                    
                }



                else
                    Console.WriteLine("That number is invalid, pick another");

                }


                    
            }

               


            
        }
    }