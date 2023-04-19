//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество столбцов матрицы: ");
int inputM = GetInput();
Console.WriteLine("Введите количество строк матрицы: ");
int inputN = GetInput();
int[,] array = new int[inputN, inputM];
GetArray(inputM, inputN);
PrintArray(array);
PrintAverageColumn(array);
int GetInput()
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

void PrintAverageColumn(int[,] array)
{
    double[,] arrayAverage = new double[1, array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           arrayAverage[0,j] = arrayAverage[0,j] + array[i,j];
        }
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
       Console.WriteLine($"Среднее арифметическое столбца {i+1} = {Math.Round(arrayAverage[0,i]/array.GetLength(0), 2)}"); 
    }   
}
