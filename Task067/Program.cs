// Задайте число
// Напишите программу, которая выведет сумму всех его цифр
System.Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumDigitsInNumber(int num)
{
    sum = sum + num % 10;
    if (num / 10 == 0) return sum;
    SumDigitsInNumber(num / 10);
    return sum;
}
int SumDigitsInNumberVar2(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigitsInNumberVar2(num / 10);// else не нужен

}
System.Console.WriteLine(SumDigitsInNumber(number));
System.Console.WriteLine(SumDigitsInNumberVar2(number));