/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

//тело программы

Random rand = new Random();

PrintArray(GenRandomArray(10, 21));

//методы

int[,,] GenRandomArray(int min, int max)
{
    int[,,] array = new int[2, 3, 2];

    bool replay_number = false;
    int number = 0;

    //проверка диапазона значений и размера матрицы
    if((array.GetLength(0) * array.GetLength(1) * array.GetLength(2)) > (max - min + 1))
    {
        throw new ArgumentException("Для матрицы таких рахмерностей невозможно создать уникальные элементы!!!");
    }

    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                replay_number = true;

                while(replay_number == true)
                {
                    number = rand.Next(min, max + 1);
                    replay_number = SearchNumberInArray(number, array);
                }

                array[k,i,j] = number;
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    Console.WriteLine("--------------------\n");
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[k, i, j]}({i},{j},{k})    ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------------");
}

bool SearchNumberInArray(int number, int[,,] array)
{
    bool replay_number = false;

    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                if(number == array[k,i,j])
                {
                    replay_number = true;
                }
            }
        }
    }

    return replay_number;
}