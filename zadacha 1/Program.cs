// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "");

string[] a = new string[n];
Console.WriteLine("Введите строки: ");
for (int i = 0; i < n; i++)
{
    a[i] = Console.ReadLine() ?? "";
}
Console.WriteLine("---------------------------------");
for (int i = 0; i < a.Length; i++)
{
    {
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
}
// Этап 1. Формирование массива из строк и вывод консоль
Console.WriteLine ("=========================================");

// Счетчик на количество символов в строке

int count = 0;
for (int i = 0; i < n; i++)
{
    if (a[i].Length <= 3)
    {
        count++;
    }
}

// формирования массива из строк меньше 3-х символов

string[] itog = new string[count];
int j = 0;
for (int i = 0; i < n; i++)
{
    if (a[i].Length <= 3)
    {
        itog[j] = a[i];
        j++;
    }
}
// вывод путем перебора

Console.WriteLine("Строки содержащие в себе 3 и менее символов: ");

Console.Write ("[");
for (int i = 0; i < a.Length; i++)
{   
    {
        Console.Write($"{a[i]} ");
    }
    
}
Console.Write ("] ->");
Console.Write ("[");
foreach (string s in itog)
{
{
    Console.Write($"{s} ");
}
}
Console.Write ("]");