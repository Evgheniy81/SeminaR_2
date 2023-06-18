/* Напишите программу, которая принимает на вход числа 
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет;
161 -> да.
*/
// Так решил я.
/*
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

*/
//А нужно было через метод "bool"

bool IsMultiplicity(int num)
{
    if (num%7 ==0 && num%23 ==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = IsMultiplicity(num);
Console.WriteLine(result);

/*

PS C:\Users\Alex\New_JK\SeminaR_02\Task_0204> dotnet run
Введите число - 12
False
PS C:\Users\Alex\New_JK\SeminaR_02\Task_0204> dotnet run
Введите число - 161
True
*/