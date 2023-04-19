//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество столбцов матрицы: ");
int inputM = GetIntInput();
Console.WriteLine("Введите количество строк матрицы: ");
int inputN = GetIntInput();
int[,] array = new int[inputN, inputM];
GetArray(inputM, inputN);
PrintArray(array);
GetSortingArray(array);
Console.WriteLine("Матрица с отсортированными по убыванию строками: ");
PrintArray(array);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void GetArray(int inputM, int inputN)
{
    for (int i = 0; i < inputN; i++)
    {
        for (int j = 0; j < inputM; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (j == array.GetLength(1) - 1)
           {
                Console.Write($"{array[i, j]} ");
           }
           else 
           {
                Console.Write($"{array[i, j]}, ");
           }
        }
        Console.WriteLine("");
    }
}

int[,] multiplicationArray(int[,] arrayA, int[,] arrayB)
{
    int[,] С = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int y = 0; y < arrayB.GetLength(0); y++)
            {
                С[i, j] += arrayA[i, y] * arrayB[y, j];
            }
        }
    }
    return С;
}
