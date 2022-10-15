Console.WriteLine("Программа для вывода всех четных чисел в промежутке от 1 до N.");

Console.Write("Введите положительное значение для числа N: ");
int N = int.Parse(Console.ReadLine()!);

if (N <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число!");

if (N == 1) Console.WriteLine("Четных чисел нет.");

if (N > 1){
    int count = 1;
    while (count <= N){
        if (count % 2 == 0) Console.Write(count + " ");
        count++;
    }
        
}