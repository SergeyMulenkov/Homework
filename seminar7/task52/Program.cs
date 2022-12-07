// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] creatMatrixRndInt = CreateMatrixRndInt(3, 4);
PrintMatrix(creatMatrixRndInt);
double[] array = ArithmeticMean(creatMatrixRndInt);
Console.Write("Среднее арифметическое элементов в столбцах: ");
PrintArray(array);


int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
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
                Console.Write($"{matrix[i, j],4} ");
            }
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] matrix)
{
    double[] ArithmeticMeanNewMassiv = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sumArithmeticMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumArithmeticMean += matrix[i, j];
        }
        ArithmeticMeanNewMassiv[j] = Math.Round(sumArithmeticMean / matrix.GetLength(0), 2);
    }
    return ArithmeticMeanNewMassiv;
}

void PrintArray(double[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) 
        {
            Console.Write($"{arr[i]}, ");
        }
        else 
        {
            Console.Write($"{arr[i]}");
        }
    }
}



