using FuncLib;

Console.Clear();

int length = new Random().Next(1, 3);
Console.WriteLine("Введите любые наборы слов или чисел, через пробел.");
Console.WriteLine($"Внимание, должно быть более {length} элементов!");
Console.Write(">> ");
string[] input = Func.GetStrArr(Console.ReadLine());
string[] output = Func.CutStrArr(input, length);
Console.WriteLine();

if (input.Length <= length)
{
    Console.WriteLine($"Неверный ввод! Должно быть больше {length} элементов.");
    Console.WriteLine();
}
else
{
    Console.WriteLine("Формируем из них массив: ");
    Console.Write(">> ");
    Console.WriteLine($"[{String.Join(", ", input)}]");
    Console.WriteLine();
    Console.WriteLine($"Сокращаем число элементов до {length}: ");
    Console.Write(">> ");
    Console.WriteLine($"[{String.Join(", ", output)}]");
    Console.WriteLine();
}
