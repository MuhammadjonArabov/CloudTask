namespace CloudTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputSpiralMatrix();
        }

        static void OutputSpiralMatrix()
        {
            Console.Write("Matritsa o'lchamini kiriting: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int num = 1;
            int rowStart = 0, rowEnd = n - 1, colStart = 0, colEnd = n - 1;

            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                for (int i = colStart; i <= colEnd; i++)
                {
                    matrix[rowStart, i] = num++;
                }
                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                {
                    matrix[i, colEnd] = num++;
                }
                colEnd--;

                if (rowStart <= rowEnd)
                {
                    for (int i = colEnd; i >= colStart; i--)
                    {
                        matrix[rowEnd, i] = num++;
                    }
                    rowEnd--;
                }

                if (colStart <= colEnd)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        matrix[i, colStart] = num++;
                    }
                    colStart++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
