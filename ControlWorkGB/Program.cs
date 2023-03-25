Console.WriteLine("Введите размер массива");
int size = Convert.ToInt16(Console.ReadLine());
string[] array=new string[size];
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Внимание! Заполнение массива происходит с 1 элемента");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент из {size}");
    array[i] = Console.ReadLine() ?? "";
}
