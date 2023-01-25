/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matr[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 2);
        }
    }
}



int m = ReadInput("Введите число строк матрицы: ");
int n = ReadInput("Введите число столбцов матрицы: ");
double[,] newmatrix = new double[m, n];
FillArray(newmatrix, m, n);
PrintArray(newmatrix);