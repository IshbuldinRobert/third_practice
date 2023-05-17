Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Квадраты чмсел от 1 до {num}: ");
for (int i = 1; Math.Pow(i, 2) <= num; i++)
{
    Console.Write($"{Math.Pow(i, 2)}, ");
}