/*
Напишите программу, которая заполнит спирально массив 4 на 4.
*/

//тело программы

using MyMethods;

int[,] array = new int[4, 4];
int i = 0;
int j = 0;
int k = 1;
bool breaker = false;

array[i, j] = k;

/*while (breaker == false)
{
    if ((i - 1 > 0) && (array[i - 1, j] == 0))
    {
        array[i - 1, j] = k + 1;
        i = i - 1;
        k = k + 1;
    }
    else
    {
        if ((j + 1 < array.GetLength(1)) && (array[i, j + 1] == 0))
        {
            array[i, j + 1] = k + 1;
            j = j + 1;
            k = k + 1;
        }
        else
        {
            if ((i + 1 < array.GetLength(0)) && (array[i + 1, j] == 0))
            {
                array[i + 1, j] = k + 1;
                i++;
                k = k + 1;
            }
            else
            {
                if ((j - 1 > 0) && (array[i, j - 1] == 0))
                {
                    array[i, j - 1] = k + 1;
                    j--;
                    k = k + 1;
                }
                else
                {
                    breaker = true;
                }
            }
        }
    }
}*/

Sl.PrintArray(array);
//методы

