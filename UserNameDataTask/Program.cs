using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisteta Eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("vali tehe (sisesta '1' '2' voi '3')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '1':
                    Reverse(userName);
                    break;
                case '2':
                    FirstLetter(userName);
                    break;
                case '3':
                    NameLenght(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void Reverse(string x)
        {
            for (int i = x.Length - 1; i >= 0; i--)
            {
                Console.Write(x[i]);
            }
        }
        public static void FirstLetter(string x)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {x[0]}");
        }

        public static void NameLenght (string x)
        {
            Console.WriteLine($"Sinu nimi on {x.Length} sümbolit pikk.");
        }
    }
}
