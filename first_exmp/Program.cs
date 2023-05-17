string f1 = "John";
string f2 = "Scot";
string f3 = "Liem";
string f4 = "Sara";
string f5 = "James";

// string[] friends = new string[5];
string[] friends = { f1, f2, "Styles", f4, f5 };

// friends[2] = f3;
// Console.Write("Какой элемент массива вывести: ");
// int count = Convert.ToInt32(Console.ReadLine());
// count--;
// Console.WriteLine(friends[count]);

Console.WriteLine($"{friends.Length}");

for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine(friends[i]);
}

foreach (string a in friends)
{
        Console.WriteLine($"foreach {a}");
        // a = "123";
}

for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine(friends[i]);
}