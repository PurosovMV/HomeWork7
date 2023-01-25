/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr) // Печать массива
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

void FillArray(int[,] matr, int a, int b)  //Заполнение двумерного массива
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matr[i, j] = new Random().Next(10, 20);
        }
    }
}

void Product(int[,] matr) //Нахождение среднего арифметического
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        Console.Write($"{sum / matr.GetLength(0):F2}; ");
    }
}

int m = ReadInput("Введите число строк матрицы: ");
int n = ReadInput("Введите число столбцов матрицы: ");
int[,] newmatrix = new int[m, n];
FillArray(newmatrix, m, n);
PrintArray(newmatrix);
Console.Write("Среднее арифметическое каждого столбца: ");
Product(newmatrix);