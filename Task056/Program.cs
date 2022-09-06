// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] CreateArrayWithRandomNumbers(int m)
{

    int[,] result = new int[m, m];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }

    return result;
}


Console.WriteLine("Введите размер массива: ");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

var array = CreateArrayWithRandomNumbers(m);
Console.WriteLine();
PrintArray(array);


int minSum = Int32.MaxValue;
int rowNumber = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        rowNumber++;
    }
}

Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой елементов под номером: " + (rowNumber) + ", с суммой елементов равной: " + (minSum));