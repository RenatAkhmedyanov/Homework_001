Console.WriteLine("Программа для нахождения максимального из трех целых чисел.");

Console.Write("Введите первое число: ");
int inputOne = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int inputTwo = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int inputThree = int.Parse(Console.ReadLine()!);

int max = inputOne;
if (inputTwo > max) max = inputTwo;
if (inputThree > max) max = inputThree;

Console.WriteLine("Максимальное из введеных чисел " + max);