// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetNumberDegree (double number, double degree)
{
    double NumberDegree = Math.Pow(number, degree);

    return NumberDegree;
}


Console.WriteLine("Введите число A: ");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
double B = double.Parse(Console.ReadLine());

double NumDegree = GetNumberDegree(A, B);

Console.WriteLine($"{A} возвести в натуральную степень {B} получаем {NumDegree}");
