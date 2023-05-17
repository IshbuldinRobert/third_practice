Console.Write("Введите координату по оси X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());

bool NotZero(int coord)
{
    if (coord != 0)
    {
        return true;
    }
    return false;
}

if (NotZero(x) && NotZero(y))
{
    if (x > 0)
    {
        if (y > 0)
        {
            Console.WriteLine($"Точка ({x}; {y}) находится в I четверти");
        }
        else Console.WriteLine($"Точка ({x}; {y}) находится в IV четверти");
    }
    if (x < 0)
    {
        if (y > 0)
        {
            Console.WriteLine($"Точка ({x}; {y}) находится в II четверти");
        }
        else Console.WriteLine($"Точка ({x}; {y}) находится в III четверти");
    }
}
else Console.WriteLine("Координаты не должны быть равны нулю");