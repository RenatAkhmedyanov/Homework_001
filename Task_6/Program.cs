Console.WriteLine("Программа для проверки четности целого числа.");

Console.Write("Введите целое число: ");
int input = int.Parse(Console.ReadLine()!);

if (input % 2 == 0){
    Console.WriteLine("Введенное число четное");
} else {
    Console.WriteLine("Введенное число нечетное");
}