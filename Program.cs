namespace Tableau_multidimensionel
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int[,] uniformArray = new int[3, 3]
            {
                {1, 2, 3},
                {2, 3, 4},
                {3, 4, 5}
            };

    
            int[][] variedArray = new int[3][];

            for (int i = 0; i < uniformArray.GetLength(0); i++)
            {
                variedArray[i] = new int[i + 1];

                for (int j = 0; j < i + 1; j++)
                {
                    variedArray[i][j] = uniformArray[i, j];
                }
            }

            Console.WriteLine("Uniform Array :");
            for (int i = 0; i < uniformArray.GetLength(0); i++)
            {
                for (int j = 0; j < uniformArray.GetLength(1); j++)
                {
                    Console.Write(uniformArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Varied Array :");
            for (int i = 0; i < variedArray.Length; i++)
            {
                for (int j = 0; j < variedArray[i].Length; j++)
                {
                    Console.Write(variedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
