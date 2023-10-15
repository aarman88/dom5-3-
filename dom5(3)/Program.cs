using System;

class Program
{
    static void Main()
    {
        try
        {
            CallMethod();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключение в вызывающем методе: {ex.Message}");
        }
    }

    static void CallMethod()
    {
        try
        {
            ThrowException();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключение в вызываемом методе: {ex.Message}");
            throw; // Поднимаем исключение обратно в вызывающий метод
        }
    }

    static void ThrowException()
    {
        throw new Exception("Генерируем исключение в вызываемом методе.");
    }
}
