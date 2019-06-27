using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Matrix----");
            Console.Write("Number of lines: ");
            int nL = int.Parse(Console.ReadLine());
            Console.Write("Numbers of rows: ");
            int nR = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter matrix values: ");
            int[,] matrix = new int[nL, nR];

            for (int i = 0; i < nL; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < nR; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Enter a matrix value: ");
            int mV = int.Parse(Console.ReadLine());
            for (int i = 0; i < nL; i++)
            {
                for (int j = 0; j < nR; j++)
                {
                    if (matrix[i, j] == mV)
                    {
                        Console.WriteLine("Position: " + "[" + i + "," + j + "]");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }
                        if (j < nR - 1)
                        {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }
                        if (i < nL - 1)
                        {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}
