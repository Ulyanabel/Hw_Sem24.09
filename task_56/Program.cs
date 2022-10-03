// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
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
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}

int RealeseMatrix(int[,] matrix)
{
    int MinRowSum = 0, Row = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int RowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            RowSum += matrix[i, j];
        }
        if (MinRowSum == 0 || MinRowSum > RowSum)
        {
            MinRowSum = RowSum;
            Row = i+1;
        }
        Console.WriteLine($"Номер строки {i+1} Сумма: {RowSum};");
    }
    return Row;
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + RealeseMatrix(matrix));