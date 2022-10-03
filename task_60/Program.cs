﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = new Random().Next(-10,11);
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
       for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.WriteLine(matrix[i, j, k] + " (" + i + ", " + j + ", " + k + ")");
}

Console.Write("Введите размер квадратной матрицы N не больше 4: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<2||n>4)
{
Console.Write("Введите размер квадратной матрицы N не больше 4: ");
n = Convert.ToInt32(Console.ReadLine());
}

int[,,] matrix = new int[n, n, n];
InputMatrix(matrix);
PrintMatrix(matrix);