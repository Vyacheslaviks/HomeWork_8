/*
Напишите программу, которая заполнит спирально массив 4 на 4.
*/

//тело программы

using MyMethods;

int[,] array = new int[4, 4];
int i = 0; //строка массива
int j = 0; //столбец массива
int k = 10; //хначение элемента массива

array[i, j] = k;
k++;

bool changes = true;


while (changes == true)
{
    changes = false;

    while (j + 1 < array.GetLength(1) && array[i, j + 1] == 0)
    {
        array[i, j + 1] = k;
        j++;
        k++;
        changes = true;
    }

    while (i + 1 < array.GetLength(0) && array[i + 1, j] == 0)
    {
        array[i + 1, j] = k;
        i++;
        k++;
        changes = true;
    }

    while (j - 1 >= 0 && array[i, j - 1] == 0)
    {
        array[i, j - 1] = k;
        j--;
        k++;
        changes = true;
    }

    while (i - 1 >= 0 && array[i - 1, j] == 0)
    {
        array[i - 1, j] = k;
        i--;
        k++;
        changes = true;
    }
}

Sl.PrintArray(array);
//методы

