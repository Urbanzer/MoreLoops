using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus pn "admin" ja sisestatud salasõna on admin1234
            //siis konsoolis kuvatakse "Tere tulemast!;
            //muu konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();




            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uuesti");
            }
        }
    }
}
