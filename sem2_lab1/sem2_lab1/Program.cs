using System;

class Program
{
    static void Main(string[] args)
    {
        /*
 * test case1: rows 4; cols 5;
 * test case2 : rows 7; cols 3;
 */

        int rows = 0;
        int cols = 0;

        try
        {
            Console.Write("Введіть кількість рядків матриці: ");
            rows = int.Parse(Console.ReadLine());
            if (rows <= 0)
            {
                throw new ArgumentException("Кількість рядків має бути натуральним числом!");
            }

            Console.Write("Введіть кількість стовпців матриці: ");
            cols = int.Parse(Console.ReadLine());
            if (cols <= 0)
            {
                throw new ArgumentException("Кількість стовпців має бути натуральним числом!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка: " + e.Message);
            Environment.Exit(1);
        }

        int[,] matrix = Generate_matrix(rows, cols);
        int[] max_Elements = Find_max(matrix);

        Console.WriteLine("Початкова матриця:");
        Print(matrix, max_Elements);

        Sort(max_Elements);

        Replace(matrix, max_Elements);

        Console.WriteLine("Відсортована матриця:");
        Print(matrix, max_Elements);
    }

    static int[,] Generate_matrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 100);
            }
        }

        return matrix;
    }

    static int[] Find_max(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] max_Elements = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int max = matrix[i, 0];
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }

            max_Elements[i] = max;
        }

        return max_Elements;
    }

    static void Sort(int[] max_Elements)
    {
        bool sorted = false;

        while (!sorted)
        {
            sorted = true;

            for (int i = 0; i < max_Elements.Length - 1; i += 2)
            {
                if (max_Elements[i] < max_Elements[i + 1])
                {
                    int storage = max_Elements[i];
                    max_Elements[i] = max_Elements[i + 1];
                    max_Elements[i + 1] = storage;
                    sorted = false;
                }
            }

            for (int i = 1; i < max_Elements.Length - 1; i += 2)
            {
                if (max_Elements[i] < max_Elements[i + 1])
                {
                    int storage = max_Elements[i];
                    max_Elements[i] = max_Elements[i + 1];
                    max_Elements[i + 1] = storage;
                    sorted = false;
                }
            }
        }
    }

    static void Replace(int[,] matrix, int[] max_Elements)
    {
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int max = matrix[i, 0];
            int maxIndex = 0;
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    maxIndex = j;
                }
            }

            matrix[i, maxIndex] = max_Elements[index];
            index++;
        }
    }
    

    static void Print(int[,] matrix, int[] max_Elements)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == max_Elements[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.Write(matrix[i, j] + "\t");
                Console.ResetColor();
            }

            Console.WriteLine();
        }
        /*
* test case1: Початкова матриця:
61      80      15      71      15
72      14      19      6       33
7       66      31      48      61
21      92      16      48      44
Вiдсортована матриця:
61      92      15      71      15
80      14      19      6       33
7       72      31      48      61
21      66      16      48      44

* test case2 : Початкова матриця:
            34      82      83      
            46      71      98      
            13      5       87      
            86      5       60
            57      6       28
            38      44      79      
            85      96      21
            Вiдсортована матриця:
            34      82      98      
            46      71      96      
            13      5       87      
            86      5       60
            83      6       28
            38      44      79      
            85      57      21


*/
    }
}
