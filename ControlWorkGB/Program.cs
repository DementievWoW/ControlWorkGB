Console.WriteLine("Введите размер массива");
int size = Convert.ToInt16(Console.ReadLine());
string[] array=new string[size];
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Внимание! Заполнение массива происходит с 1 элемента");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент из {size}");
    array[i] = Console.ReadLine() ?? ""; // если null, то "" строка
}
size= 0;
foreach (var a in array)
{
    if (a.Length<=3)
    {
        size++;
    }
}
string[] array2 = new string[size];
int tmp = 0;
foreach (var a in array)
{
    if (a.Length <= 3)
    {
        array2[tmp] = a;
        tmp++;
    }
}

Console.WriteLine("Изначальный массив");
Console.Write("[");
foreach (var item in array)
{
    Console.Write(" "+item+", ");
}
Console.WriteLine("]");
Console.WriteLine("Конечный массив");
Console.Write("[");
foreach (var item in array2)
{
    Console.Write(" " + item + ", ");
}
Console.WriteLine("]");