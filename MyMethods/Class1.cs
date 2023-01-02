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
}
