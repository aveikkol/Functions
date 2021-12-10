using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma eesnime
            //programm kuvab kasutaja eesnime pikust
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem, kui kolm rida koodi 

            Console.WriteLine("sisesta oma eesnime:");
            string userName = Console.ReadLine();

            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

            for(int i = userInput.Length -1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }


        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }
        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        public static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
    }
}
