// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
void NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void SortRowInMatrix(int[,] matrix)
{
    int[] SumRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow[i] += matrix[i, j];
        }
    }
    int temp = SumRow[0];
    int NumberRow = 0;
    for (int i = 0; i < SumRow.Length; i++)
    {
        if (SumRow[i] < temp)
        {
            temp = SumRow[i];
            NumberRow = i + 1;
        }
    }
    Console.WriteLine("Минимальная сумма элементов в строке:" + NumberRow);
    Console.WriteLine("Минимальная сумма элементов равна:" + temp);
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
Console.WriteLine("Начальная матрица: ");
NewMatrix(matrix);
SortRowInMatrix(matrix);
