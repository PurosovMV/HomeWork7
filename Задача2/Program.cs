/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr)
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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}



int m = ReadInput("Введите номер строки матрицы: ");
int n = ReadInput("Введите номер столбца матрицы: ");
int[,] newmatrix = new int[5, 5];
FillArray(newmatrix);
PrintArray(newmatrix);
int row = newmatrix.GetLength(0);
int col = newmatrix.GetLength(1);
if (row - 1 < m)
{
    Console.WriteLine("нет такого элемента");
}
else if (col - 1 < n)
{
    Console.WriteLine("нет такого элемента");
}
else
{
    Console.WriteLine(newmatrix[m, n]);
}





