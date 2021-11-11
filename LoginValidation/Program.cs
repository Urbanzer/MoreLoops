using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus pn "admin" ja sisestatud salasõna on admin1234
            //siis konsoolis kuvatakse "Tere tulemast!;
            //muu konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutaja on kolm katset


            var validateCheck = true;
            var triesTimes = 2;

            
                while (validateCheck == true)
                {
                    Console.WriteLine("Sisesta kasutajatunnus:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Sisesta salasõna:");
                    string userPassword = Console.ReadLine();


                    if (triesTimes > 0)
                    {
                        if (userName != "admin" && userPassword != "admin1234")
                        {

                            Console.WriteLine($"Vale kasutajatunnus voi salasona. Veel {triesTimes} katset.");
                            triesTimes -= 1;

                        }
                        else if (userName == "admin" && userPassword == "admin1234")
                        {
                            Console.WriteLine("Palju onne! Sisestasite oiged andmed!");
                            Console.WriteLine("Kena paeva!");
                            break;
                        }

                    }

                    else if (triesTimes == 0)
                    {

                        Console.WriteLine($"Vale kasutajatunnus voi salasona. Veel {triesTimes} katset.");
                        break;
                    }
        }
      }
    }
  }

    
        
    
