// Напишите программу, которая на вход принимает два
// числа А и В, и возводит число А в степень В с помощью рекурсии

int[] InputTwoNumbers()
{
    int[] numbers = { 0, 0 };
    while (true)
    {
        Console.WriteLine("Введите 2 целых числа через пробел: ");
        numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (numbers.Length == 2) break;
        Console.WriteLine("Введённые данные не верны ");
    }
    return numbers;
}

int Power(int numA, int numB)
{
    if (numB == 0) return 1;
    // numA = numA * numA;
    //System.Console.WriteLine(numA);
    return numA * Power(numA, numB - 1);
}
int[] twoNumbers = InputTwoNumbers();
System.Console.WriteLine(Power(twoNumbers[0], twoNumbers[1]));
