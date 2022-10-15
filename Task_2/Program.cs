Console.WriteLine("Программа для нахождения наибольшего из двух целых чисел");

Console.Write("Введите первое целое число: ");
int inputOne = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число: ");
int inputTwo = int.Parse(Console.ReadLine()!);

if(inputOne > inputTwo){
    Console.WriteLine("Наибольшее число " + inputOne);
    Console.WriteLine("Наименьшее число " + inputTwo);
} else {
    Console.WriteLine("Наибольшее число " + inputTwo);
    Console.WriteLine("Наименьшее число " + inputOne);
}
