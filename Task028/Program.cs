// напишите программу, которая принимает на вход
// число N и выдаёт п

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
System.Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i < num; i++)
    {
        try
        {
            checked
            {
                fact = fact * i;
            }
        }
        catch(Exception)
        {
           System.Console.WriteLine("Переполнение типа!");
           break;
        }
    }
    return fact;
}