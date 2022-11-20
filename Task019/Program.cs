// Напишите программу, которая пртнимает на вход пятизначное
// число и проверяет, являетса ли оно палиндромом.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите  числo: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (PolydromeCheck(number))

        {
            Console.WriteLine("Число  полидром");
        }
        else
        {
            Console.WriteLine("Число не полидром");
        }

        bool PolydromeCheck(int number)
        {
            bool resultPolydromeCheck = true;
            int[] array = NumberToArray(number);
            //ArrayOfDigitToString(array);
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    resultPolydromeCheck = false;
                    break;
                }
            }
            return resultPolydromeCheck;
        }
        //ArrayOfDigitToString(NumberToArray(number));

        int[] NumberToArray(int numb)
        {
            int amountDigitInNumber = AmountDigitInNumber(numb);
            int[] arrayOfDigit = new int[amountDigitInNumber];

            for (int i = amountDigitInNumber - 1; i >= 0; i--)
            {
                arrayOfDigit[i] = numb % 10;
                numb = numb / 10;
                //ArrayOfDigitToString(arrayOfDigit);
            }
            return arrayOfDigit;
        }
        void ArrayOfDigitToString(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
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
    }
}