// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает , что третьей цифры нет.

int number = 1256;
int amountDigitInNumber = AmountDigitInNumber(number);

if (amountDigitInNumber >= 3)
{
    int result = number;
    for (int i = amountDigitInNumber - 3; i > 0; i--)
    {
        //Console.WriteLine(number);
        result = result / 10;
       // Console.WriteLine(result);
    }
    int digitalThree = result % 10;
    Console.WriteLine(digitalThree);
}
else
{
Console.WriteLine($"В числе {number} меньше трёх цифр");
}

int AmountDigitInNumber(int num)
{
    int res = 1;
    while (true)
    {
        if (num / 10 == 0) break;
        num = num / 10;
        res++;
    }
    Console.WriteLine($"Количество цифр в числе {res}");
    return res;
}
