// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
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

int[,] ReleaseMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC=new int[matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k=0;k<matrixB.GetLength(0);k++)
                matrixC[i,j]=matrixC[i,j]+matrixA[i,k]*matrixB[k,j];
        }
    }
return matrixC;
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[n, m];
int[,] matrixB = new int[m, n];
InputMatrix(matrixA);
Console.WriteLine("Исходная матрица А: ");
PrintMatrix(matrixA);
InputMatrix(matrixB);
Console.WriteLine("Исходная матрица В: ");
PrintMatrix(matrixB);
Console.WriteLine("Произведение матрицы А и матрицы В: ");
PrintMatrix(ReleaseMatrix(matrixA,matrixB));