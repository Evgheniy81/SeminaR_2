/*
Напишите пр-му, к-рая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.
Н-р:
5, 25 -> да;
-4, 16 -> да;
25, 5 -> да;
8,9 -> нет;
*/
//////////
/*
Console.Write("Введите число 1 => ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 => ");
int N2 = Convert.ToInt32(Console.ReadLine());
if (N1==N2*N2 || N2==N1*N1)  //  "==" - значения равны др.др. "||" - команда "или"
{
    Console.WriteLine($"одно из этих чисел является квадратом другого");
}
else
{
    Console.WriteLine($"эти числа не являются квадратами друг друга");   
}
*/


/////////////////

bool IsMultiplicity(int num1, int num2)
{
    if (num1 == num2*num2 || num2 == num1*num1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.Write("Введите число 1 - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 - ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = IsMultiplicity(num1, num2);
Console.WriteLine(result);

// Можно и так
/*

bool IsSquereNumber(int num1, int num2)
{
    if (Math.Pow(num1, 2) == num2 || num2 * num2 == num1) return true;
    return false;
}
Console.WriteLine(IsSquereNumber(-5, 25));
*/