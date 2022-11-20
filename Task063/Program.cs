// Задайте значение N
// Напишите программу, которая выведет все натуральные числа от 1 до N
System.Console.WriteLine("Введите целе число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 0) return;
    System.Console.WriteLine($"{num} ");// 6 5 4 3 2 1 
    NaturalNumbers(num - 1);
    System.Console.WriteLine($"{num} ");// 1 2 3 4 5 6 
}
NaturalNumbers(number);