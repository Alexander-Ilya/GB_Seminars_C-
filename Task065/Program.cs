// Задайте значение M и N
// Напишите программу, которая выведет все натуральные числа от M до N
int[] InputTwoNumbers()
{
    int[] numbers = { 0, 0 };
    while (true)
    {
        Console.WriteLine("Введите 2 целых числа через пробел: ");
        numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (numbers.Length == 2 && numbers[0] < numbers[1]) break;
        Console.WriteLine("Введённые данные не верны ");
    }
    return numbers;
}

void NaturalNumbers(int numM, int numN)
{
    if (numM > numN) return;
    System.Console.WriteLine($"{numM} ");
    NaturalNumbers(numM + 1, numN);
    //System.Console.WriteLine($"{numN} ");
}
int[] twoNumbers = InputTwoNumbers();
NaturalNumbers(twoNumbers[0], twoNumbers[1]);
