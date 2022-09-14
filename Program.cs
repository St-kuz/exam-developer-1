// Написать программу, которая из имеющегося массива СТРОК формирует массив СТРОК, длинна которых меньше или равна 3 символа.
// примеры
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] - > ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Write("Введите 1 значение массива ");
string A = Convert.ToString(Console.ReadLine());

Console.Write("Введите 2 значение массива " );
string B = Convert.ToString(Console.ReadLine());

Console.Write("Введите 3 значение массива " );
string C = Convert.ToString(Console.ReadLine());

Console.Write("Введите 4 значение массива " );
string D = Convert.ToString(Console.ReadLine());


string[] longMassive = {A, B, C, D};

for (int i = 0; i < longMassive.Length; i++)
{
    if (longMassive[i].Length < 4) Console.Write($"{longMassive[i]} ");
}