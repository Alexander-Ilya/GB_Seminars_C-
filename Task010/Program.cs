// Напишите программу, которая пртнимает на вход трёхзначное
// число и на выходе показыват вторую цифру этого числа

Console.Write("Введите трёхзначное числo: ");
int number = Convert.ToInt32(Console.ReadLine());
if (AmountDigitInNumber(number) == 3)
{
    int digital = (number % 100) / 10;
    //Console.WriteLine($"Вторая цифра числа {number} => {(number%100)/10}");
    Console.WriteLine(digital);
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

