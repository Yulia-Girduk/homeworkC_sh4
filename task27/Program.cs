// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumDigit (int num)
{
    int sumDigit = 0;
    
    while (num != 0)
    {
        sumDigit = sumDigit + num % 10;
        num = num / 10;
    }

    return sumDigit; 
}

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());

int sumNumberDigit = GetSumDigit(Number);

Console.WriteLine($"Сумма цифир числа {Number} = {sumNumberDigit}");