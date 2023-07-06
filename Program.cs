//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// int rows = 3;
// int cols = 4;
// double[,] matrix = new double[rows, cols];

// Random rand = new Random();
// for (int r = 0; r < rows; r++)
// {
//     for (int c = 0; c < cols; c++)
//     {
//         matrix[r, c] = rand.NextDouble();
//     }
// }

// for (int r = 0; r < rows; r++)
// {
//     Console.WriteLine($"[{r + 1}]");
//     for (int c = 0; c < cols; c++)
//     {
//         Console.Write(matrix[r, c].ToString("F2") + " ");
//     }
//     Console.WriteLine();
// }



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5; 
// int m = 7; 
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
// {
//     arr[i, j] = random.Next(10, 99);
// Console.Write("{0} ", arr[i, j]);
// }
// Console.WriteLine();
// }
//     if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
// Console.WriteLine("Элемент не существует  ");
// }
//     else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
// }
// Console.ReadLine();

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m, n];

// void mas(int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.Next(1, 9);
//             Console.Write($"{randomArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void arif(int m, int n)
// {
//     Console.Write("Среднее арифметическое каждого столбца: ");
//     int i, j;
//     Random rand = new Random();
//     for (j = 0; j < n; j++)
//     {
//         double sum = 0;
//         for (i = 0; i < m; i++)
//         {
//             sum = sum + randomArray[i, j];
//         }
//         Console.Write($"{sum / (i):F1}; ");
//     }
// }
// mas(m, n);
// arif(m, n);