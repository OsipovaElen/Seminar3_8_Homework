//Напишите программу, которая заполнит спирально массив 4 на 4.


Console.WriteLine("Введите размерность квадратного массива: ");
int input = GetIntInput();
int[,] array = GetArray(input);
PrintArray(array);


int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[,] GetArray(int input)
{
    int[,] array = new int[input, input];
    int g = 1;
    for (int y = 0; y < input; y++) 
    {
        array[0, y] = g;
        g++;
    }
    for (int x = 1; x < input; x++) 
    {
        array[x, input - 1] = g;
        g++;
    }
    for (int y = input - 2; y >= 0; y--) 
    {
        array[input - 1, y] = g;
        g++;
    }
    for (int x = input - 2; x > 0; x--) 
    {
        array[x, 0] = g;
        g++;
    }
    int c = 1;
    int d = 1;
    while (g < input * input) 
    {
        while (array[c, d + 1] == 0) 
        {
            array[c, d] = g;
            g++;
            d++;
        }  
        while (array[c + 1, d] == 0) 
        {
            array[c, d] = g;
            g++;
            c++;
        }
        while (array[c, d - 1] == 0) 
        {
            array[c, d] = g;
            g++;
            d--;
        }
        while (array[c - 1, d] == 0) 
        {
            array[c, d] = g;
            g++;
            c--;
        }
        for (int x = 0; x < input; x++) 
        {
            for (int y = 0; y < input; y++) 
            {
                if (array[x, y] == 0) 
                {
                    array[x, y] = g;
                }
            }
        }
    }
    return array;
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
