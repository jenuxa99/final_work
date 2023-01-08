// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int size = 5;
string[] Arr = new string[size];
int i = 0;

Console.WriteLine("Добрый день!");
System.Threading.Thread.Sleep(1000);
Console.WriteLine($"Заполните массив размером {size}");
System.Threading.Thread.Sleep(2000);

while (i < size)
{
    Console.WriteLine("Введите значение любого типа и нажмите Enter, чтобы продолжить: ");
    Arr[i] = Console.ReadLine();
    i++;
}

Console.Write("Введенные значения:" + "\t");
System.Threading.Thread.Sleep(1000);

for (i = 0; i < size; i++)
{
    Console.Write($"{Arr[i]}" + "\t");
}
Console.WriteLine(String.Empty);

System.Threading.Thread.Sleep(2000);
Console.WriteLine("Формируем новый массив по условию...");
System.Threading.Thread.Sleep(2000);
Console.WriteLine("Новый массив:" + "\t");

int innerSize = 1;
string[] InnerArr = new string[innerSize];
int j = 0;

for (i = 0; i < size; i++)
{
    if (Arr[i].Length <= 3)
    {
        InnerArr[j] = Arr[i];
        innerSize++;
        Console.Write($"{InnerArr[j]} \t");
    }
}