Console.WriteLine("Введите размер массива");
int size = Convert.ToInt16(Console.ReadLine());
string[] initalyArray=new string[size];
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Внимание! Заполнение массива происходит с 1 элемента");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < initalyArray.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент из {size}");
    initalyArray[i] = Console.ReadLine() ?? ""; // если null, то "" строка
}
size= 0;
foreach (var a in initalyArray)
{
    if (a.Length<=3)
    {
        size++;
    }
}
string[] processedArray = new string[size];
int tmp = 0;
foreach (var a in initalyArray)
{
    if (a.Length <= 3)
    {
        processedArray[tmp] = a;
        tmp++;
    }
}

Console.WriteLine("Изначальный массив");
Console.Write("[");
foreach (var item in initalyArray)
{
    Console.Write(" "+item+", ");
}
Console.WriteLine("]");
Console.WriteLine("Конечный массив");
Console.Write("[");
foreach (var item in processedArray)
{
    Console.Write(" " + item + ", ");
}
Console.WriteLine("]");