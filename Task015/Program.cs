string[] dayOfWeek = {"понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Введите день недели: ");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());

if (numberDayOfWeek > 0 && numberDayOfWeek <= 7)
{
    if (numberDayOfWeek == 6 || numberDayOfWeek == 7)
    {
        Console.WriteLine($"День № {numberDayOfWeek}  {dayOfWeek[numberDayOfWeek-1]}  выходной");
    }
    else
    {
         Console.WriteLine($"День № {numberDayOfWeek}  {dayOfWeek[numberDayOfWeek-1]}  не выходной");
    }
}
else
{
     Console.WriteLine($"День № {numberDayOfWeek}  не существует");
}
