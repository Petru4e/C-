// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




            Console.WriteLine("Enter size matrix");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] array2d = new int[size, size];
            FillMatrix(array2d);
            PrintArray(array2d);


            void FillMatrix(int[,] matrix)
            {
                int n = matrix.GetLength(0);
                int dx = 0, dy = 1;
                int x = 0, y = 0;
                double k = Math.Pow(n, 2) + 1;
                for (int i = 1; i < k; i++)
                {
                    matrix[x,y] = i;
                    int nx = x + dx;
                    int ny = y + dy;
                    if ((nx >= 0 && nx < n) && (ny >= 0 && ny < n) && matrix[nx, ny] ==0)
                    {
                        x = nx;
                        y = ny;
                    }
                    else
                    {
                        if (x < y) (dx, dy) = (dy, dx);
                        else (dx,dy) = (dy,-dx);
                        x = x + dx;
                        y = y + dy;
                    }
                    
                }
            }

            void PrintArray(int[,] matrix)
            {

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == matrix.GetLength(1) - 1) Console.Write($" {matrix[i, matrix.GetLength(1) - 1].ToString("00")} ");
                        else Console.Write($" {matrix[i, j].ToString("00")} |");
                    }
                    Console.WriteLine($"|");
                }
            }