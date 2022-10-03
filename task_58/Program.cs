// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
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

void ProzMatrix(int[,] MatrixOne, int[,] MatrixTwo)
{
    Console.WriteLine();
   int[,] ResultMatrix = new int[MatrixOne.GetLength(0), MatrixOne.GetLength(1)];
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixOne.GetLength(1); j++)
        {
            ResultMatrix[i, j] = MatrixOne[i, j] * MatrixTwo[i, j];
            Console.Write(ResultMatrix[i, j] + " \t");
        }
         Console.WriteLine();
    } 
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] MatrixOne = new int[n, m];
int[,] MatrixTwo = new int[n, m];
Console.WriteLine("Начальная матрица 1: ");
NewMatrix(MatrixOne);
Console.WriteLine();
Console.WriteLine("Начальная матрица 2: ");
NewMatrix(MatrixTwo);
Console.WriteLine("Конечный результат: ");
ProzMatrix(MatrixOne, MatrixTwo);