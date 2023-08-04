using System.Linq.Expressions;

namespace gæt_nummeret_spil
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();

            bool state = true;
            while (state == true)
            {
                int nummer = random.Next(1, 11);
                

                bool gæt = true;
                while (gæt == true)
                {
                    Console.WriteLine("Vælg et tal fra 1 til 10");
                    int værdi = Convert.ToInt32(Console.ReadLine());

                    if (nummer == værdi)
                    {
                        Console.WriteLine("Flot klaret. Det er rigtigt!");
                        gæt = false;
                    }

                    else
                    {
                        Console.WriteLine("Dumme idiot, Forkert. Prøv igen.");
                    }
                   
                }
                Console.WriteLine("Vil du spille igen?");
                
                string igen = Console.ReadLine();
                if(igen == "nej" || igen == "Nej")
                {
                    state = false; 
                }
                else
                {
                    state = true;
                }

            }

            
            



        }
    }
}


