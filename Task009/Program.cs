// Задача 9. Напишите программу, которая
// 1. Выводит слуцайное число отрезка [10. 99] и 
// 2. показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);

// Решение без методов
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if (secondDigit >= firstDigit)
{
    Console.WriteLine($"Наибольшая цифра числа {secondDigit}");
}
else Console.WriteLine($"Наибольшая цифра числа {firstDigit}");


// Решение с методом
int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (secondDigit >= firstDigit) return secondDigit;
    return firstDigit;

    // return secondDigit >= firstDigit ? secondDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {maxDigit}");