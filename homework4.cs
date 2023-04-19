//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.WriteLine("Введите размерность измерения x массива: ");
int inputX = GetIntInput();
Console.WriteLine("Введите размерность измерения y массива: ");
int inputY = GetIntInput();
Console.WriteLine("Введите размерность измерения z массива: ");
int inputZ = GetIntInput();
int[,,] array = GetArray(inputX, inputY, inputZ);
PrintArray(array);


int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[,,] GetArray(int x, int y, int z)
{
    int[,,] C = new int[x, y, z];
    int g = 1;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                C[i, j, k] = g;
                if (C[i, j, k] < 10) 
                {
                    C[i, j, k] = C[i, j, k] * 10;
                }
                g++;
            }

        }
    }
    return C;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i}, {j}, {k})");
            }
        }
    }
}
