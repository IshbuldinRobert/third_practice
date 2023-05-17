Console.Write("Введите номер четверти системы координат: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 5)
{
    if (num == 1)
    {
        Console.WriteLine("Диапазон X и Y (0; +бесконечности)");
    }
    if (num == 2)
    {
        Console.WriteLine("Диапазон X (-бесконечности; 0), а Y (0; +бесконечности)");
    }
    if (num == 3)
    {
        Console.WriteLine("Диапазон X (-бесконечности; 0), а Y (-бесконечности; 0)");
    }
    if (num == 4)
    {
        Console.WriteLine("Диапазон X (0; +бесконечности), а Y (-бесконечности; 0)");
    }
}
else Console.WriteLine("Введите число от 1 до 4 включительно!");