// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool NumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return true;
            }
        }
    }

    return false;
}


void CreateArrayWithRandomNumbers(int[,,] array, int minNumber = 0, int maxNumber = 9)
{
    var random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = random.Next(minNumber, maxNumber + 1);

                    if (NumberInArray(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }

            }
        }
    }
}


void PrintArrayWithIdex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write("({0},{1},{2})\t", i, j, k);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}


int arraySizeX = 2;
int arraySizeY = 2;
int arraySizeZ = 2;
int minNumber = 10;
int maxNumber = 99;
int[,,] testArray = new int[arraySizeX, arraySizeY, arraySizeZ];


CreateArrayWithRandomNumbers(testArray, minNumber, maxNumber);
PrintArrayWithIdex(testArray);