using System.Security.Cryptography;

namespace slotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[3];
            
            Random random = new Random();

            for (int i = 0; i <randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(3,3);

            }

            Console.WriteLine("The slot machine result:");
        }
    }
    
}