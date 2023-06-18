﻿/*Напишите прогу, к-рая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Н-р: 34, 5 -> не кратно, остаток 4;
16, 4 -> кратно
*/
Console.Write("Введите число 1 => ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 => ");
int N2 = Convert.ToInt32(Console.ReadLine());
int N3 = N1%N2;
/*Console.Write("remainder => ");
Console.WriteLine(remainder);
*/

if (N3 > 0)
{
    Console.Write($"{N1} не кратно {N2}, остаток = {N3}");
    
}
else
{
    Console.Write($"{N1} кратно {N2} ");
 }
/*
PS C:\Users\Alex\New_JK\Seminar_02\Task_0203> dotnet run
Введите число 1 => 65
Введите число 2 => 6
65 не кратно 6, остаток = 5
PS C:\Users\Alex\New_JK\Seminar_02\Task_0203> dotnet run
Введите число 1 => 60
Введите число 2 => 10
60 кратно 10 
*/
