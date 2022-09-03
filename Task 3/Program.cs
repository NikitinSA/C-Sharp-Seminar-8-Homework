/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Clear();

int[,] firstArray = new int[2, 2];
int[,] secondArray = new int[2, 2];
int[,] resultArray = new int[2, 2];

FillArray(firstArray, secondArray);
PrintArray(firstArray, secondArray);
MultiplicationOfTwoArray(firstArray, secondArray, resultArray);
Console.WriteLine();
PrintResultArray(resultArray);

void FillArray(int[,] firstArray, int[,] secondArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            firstArray[i, j] = new Random().Next(1, 9);
        }
    }
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            secondArray[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] firstArray, int[,] secondArray)
{
    Console.WriteLine("Первая двумерная матрица:");
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            Console.Write($"{firstArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Вторая двумерная матрица:");
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            Console.Write($"{secondArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplicationOfTwoArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

void PrintResultArray(int[,] resultArray)
{
    Console.WriteLine("Результат умножения двумерных матриц:");
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            Console.Write($"{resultArray[i, j]} ");
        }
        Console.WriteLine();
    }
}