using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        case 1:
        rows = 7
        cols = 7
        
        case 2:
        rows = 3 
        cols = 3
         
         */
        Console.Write("Enter 1 if you want to enable custom settings, or enter 0 if you want to see a test script: ");
        int answer = Convert.ToInt16(Console.ReadLine());
        switch (answer)
        {
            case 1:
                Console.Write("Input rows: ");
                try
                {
                int rows = Convert.ToInt16(Console.ReadLine());
                Console.Write("Input cols: ");
                int cols = Convert.ToInt16(Console.ReadLine());
                if (rows != cols)
                {
                    Console.Write("Error");

                    return;
                }

                SET(rows, cols);
                break;
                }
                catch 
                {
                    Console.WriteLine("Try again. The input data is incorrect. ");
                    break;
                }
    
            case 0:
                SET(6, 6);
                break;
        }

        static void SET(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            
                    Random random_numbers = new Random();
            
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = random_numbers.Next(1,100);
                        }
                    }
            
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(matrix[i, j] + "\t");
                        }
            
                        Console.WriteLine();
                    }
            
                    int x = 0;
                    int y = 1;
                    int length = rows - 1;
                    if (length < 1)
                    {
                        return;
                    }
            
                    int dir = 0;
                    int max = matrix[x, y];
                    int max_x = x;
                    int max_y = y;
                    while (length > 0)
                    {
                        for (var i = 0; i < length; i++)
                        {
                            if (max < matrix[x, y])
                            {
                                max = matrix[x, y];
                                max_x = x;
                                max_y = y;
                            }
            
                            if (i != length - 1)
                            {
                                switch (dir)
                                {
                                    case 0: y++; break;
                                    case 1: x++; break;
                                    case 2: x--; y--; break;
                                }
                            }
                        }
                        switch (dir)
                        {
                            case 0: x++; break;
                            case 1:x--; y--; break;
                            case 2: y++; break;
                        }
                        length--;
                        dir++;
                        if (dir > 2) dir = 0;
                    }
            
                    Console.WriteLine("Max:  {0} [{1}, {2}]", max, max_x, max_y);
            
                    int pivsuma = 0;
                    for (int i = 0; i < rows; i++) pivsuma += matrix[i, i];
                    pivsuma /= 2;
                    Console.WriteLine("Pivsuma {0} ", pivsuma);
            
                    dir = 0;
                    x = rows - 1;
                    y = rows - 2;
                    length = rows - 1;
                    while (length > 0)
                    {
                        for (var i = 0; i < length; i++)
                        {
                            if (pivsuma > matrix[x, y])
                            {
                                Console.WriteLine("{0} [{1}, {2}]", matrix[x, y], x, y);
                            }
            
                            if (i != length - 1)
                            {
                                switch (dir)
                                {
                                    case 0: y--; break;
                                    case 1: x--; break;
                                    case 2: x++; y++; break;
                                }
                            }
                        }
                        switch (dir)
                        {
                            case 0: x--; break;
                            case 1: x++; y++; break;
                            case 2: x--; break;
                        }
                        length--;
                        dir++;
                        if (dir > 2) dir = 0;
                    }
        }
        /*
case 1:
Input rows: 7
Input cols: 7
45      96      83      9       22      23      51
91      14      97      24      67      52      77
78      96      52      8       87      17      72
55      22      15      15      57      77      52
15      17      94      49      52      92      81
49      32      50      30      82      45      68
16      14      35      96      75      65      79

max namber : 97 [1, 2]
Pivsuma 151
65 [6, 5]
75 [6, 4]
96 [6, 3]
35 [6, 2]
14 [6, 1]
16 [6, 0]
49 [5, 0]
15 [4, 0]
55 [3, 0]
78 [2, 0]
91 [1, 0]
96 [2, 1]
15 [3, 2]
49 [4, 3]
82 [5, 4]
52 [4, 4]
49 [4, 3]
94 [4, 2]
15 [3, 2]
52 [2, 2]
15 [3, 3]

case 2:

Input rows: 3
Input cols: 3
80      86      28
10      55      75
51      22      46
86 [0, 1]
Pivsuma 90
22 [2, 1]
51 [2, 0]
10 [1, 0]
 */
        
    }
}