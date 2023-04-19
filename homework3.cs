//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.WriteLine("Введите количество столбцов матрицы A: ");
int inputColmnA = GetIntInput();
Console.WriteLine("Введите количество строк матрицы A: ");
int inputLineA = GetIntInput();
Console.WriteLine("Введите количество столбцов матрицы B: ");
int inputColmnB = GetIntInput();
int[,] arrayA = GetArray(inputLineA, inputColmnA);
int[,] arrayB = GetArray(inputColmnA, inputColmnB);
Console.WriteLine("Матрица A: ");
PrintArray(arrayA);
Console.WriteLine("Матрица B: ");
PrintArray(arrayB);
int[,] arrayС = multiplicationArray(arrayA, arrayB);
Console.WriteLine("Результат произведения матриц AxB: ");
PrintArray(arrayС);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[,] GetArray(int arrayLine, int arrayColmn)
{
    int[,] C = new int[arrayLine, arrayColmn];
    for (int i = 0; i < arrayLine; i++)
    {
        for (int j = 0; j < arrayColmn; j++)
        {
            C[i, j] = new Random().Next(0, 10);
        }
    }
    return C;
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
    int[,] C = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int y = 0; y < arrayB.GetLength(0); y++)
            {
                C[i, j] += arrayA[i, y] * arrayB[y, j];
            }
        }
    }
    return C;
}