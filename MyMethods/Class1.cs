namespace MyMethods;

public static class Sl
{
    public static int InputInt()
    {
        bool isParse = int.TryParse(Console.ReadLine(), out int number);

        if (isParse)
        {
            return number;
        }
        else
        {
            throw new ArgumentException("Введено некорректное значение!");
        }
    }

    public static int[,] GenerateRandomArrayInt(int count_rows, int count_columns, int min, int max)
    {
        int[,] array = new int[count_rows, count_columns];
        Random rand = new Random();

        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = rand.Next(min, max + 1);
            }
        }

        return array;
    }

    public static int[] GenerateRandomArrayInt(int size, int min, int max)
    {
        int[] array = new int[size];
        Random rand = new Random();

        for(int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(min, max + 1);
        }

        return array;
    }

    public static void PrintArray(int[,] array)
    {
        Console.WriteLine("-----------------------");
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]}   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------------------");
    }

    public static void PrintArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}   ");
        }
    }
}
