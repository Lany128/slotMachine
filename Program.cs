using System;
using System.Security.Cryptography;

namespace slotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[,] array2D = new int[3,3];
            int[] slotRandomNum = {'1','2','3'};


            Random randomNumber= new Random();
            int slotMachineNum = slotRandomNum[randomNumber.Next(slotRandomNum.Length)];
            


            // 1 1 1
            // 1 1 1
            // 1 1 1
            // Fill the array
            for (int i = 0; i < 3; i++) // Loop through rows
            {
                for (int j = 0; j < 3; j++)// loop through columns
                {
                    array2D[i, j] = slotMachineNum; // Set each element to 1
                }
               
            }

            // Print the 3x3 array
            for (int i = 0;i < 3; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    Console.Write(array2D[i, j]); // Print elements in a row
                }
                Console.WriteLine();// Move to the next row
            }


           
        }
    }

}