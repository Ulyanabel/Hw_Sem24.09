// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,5}", matrix[i, j]);
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int minElem = matrix[i, 0];
        for (int k = 0;k < matrix.GetLength(1) - 1;k++)
        {
            for (int j = 0; j < (matrix.GetLength(1)) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    minElem = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = minElem;
                }
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количествово столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Конечный массив: ");
PrintMatrix(matrix);