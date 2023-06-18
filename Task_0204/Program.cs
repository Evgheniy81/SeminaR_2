/* Напишите программу, которая принимает на вход числа 
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет;
161 -> да.
*/
Console.Write("Введите число 1 => ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 => ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3 => ");
int N3 = Convert.ToInt32(Console.ReadLine());
int N4 = N1%(N2*N3);
if (N4 == 0)
{
    Console.Write($"{N1} кратно {N2} и {N3}");
}
else
{
    Console.Write($"{N1} не кратно {N2} и {N3}");
}
/*
проверк работы:
PS C:\Users\Alex\New_JK\SeminaR_02\Task_0204> dotnet run
Введите число 1 => 161
Введите число 2 => 14
Введите число 3 => 23
161 не кратно 14 и 23
PS C:\Users\Alex\New_JK\SeminaR_02\Task_0204> dotnet run
Введите число 1 => 161
Введите число 2 => 7
Введите число 3 => 23
161 кратно 7 и 23
*/