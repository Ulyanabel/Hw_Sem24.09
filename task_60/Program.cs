// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
void NewMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int  k  = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = new Random().Next(-10, 11);
        }
    }
}

void PrintMatrix(int[,,] MatrixOne)
{
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixOne.GetLength(1); j++)
        {
            for (int  k  = 0; k < MatrixOne.GetLength(2); k++)
                Console.WriteLine(MatrixOne[i, j, k] + " (" + i + ", " + j + ", " + k + ")");
        }
    }
}

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  Z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] MatrixOne = new int[x, y, z];
NewMatrix(MatrixOne);
PrintMatrix(MatrixOne);