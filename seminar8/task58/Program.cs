﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix = NewRndMatrix(3, 6);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = NewRndMatrix(6, 3);
PrintMatrix(matrix2);
Console.WriteLine();

int[,] multiplyTwoMatrix = MultiplyTwoMatrix(matrix, matrix2);
PrintMatrix(multiplyTwoMatrix);

int[,] MultiplyTwoMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] multiplyTwoMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < multiplyTwoMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiplyTwoMatrix.GetLength(1); j++)
            {
                multiplyTwoMatrix[i, j] = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    multiplyTwoMatrix[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }
    return multiplyTwoMatrix;
}

int[,] NewRndMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write($"{matrix[i, j],4}, ");
            }
            else 
            {
                Console.Write($"{matrix[i, j],4}");
            }
        }
        Console.WriteLine();
    }
}