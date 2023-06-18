/* Напишите программу которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.
Н-р: 456 -> 46
///////////
В I-варианте лишнее нахождение 2 цифры, а нам нужны только первая и третья.
int number = new Random().Next(100, 1000);
int firstNum = number / 100;
int secondNum = number % 100 / 10;
int thirdNum = number % 10;
int newNum = firstNum * 10 + thirdNum;
Console.WriteLine($"Our random number is => {number}");
Console.WriteLine($"Our first number is => {firstNum}");
Console.WriteLine($"Our second number is => {secondNum}");
Console.WriteLine($"Our trind number is => {thirdNum}");

Console.WriteLine($"Our new number is => {newNum}");
*/
/*
int number = new Random().Next(100, 1000);
int firstNum = number / 100;
int thirdNum = number % 10;
int newNum = firstNum * 10 + thirdNum;
Console.WriteLine($"Our random number is => {number}");
Console.WriteLine($"Our first number is => {firstNum}");
Console.WriteLine($"Our trind number is => {thirdNum}");
Console.WriteLine($"Our new number is => {newNum}");
*/
/*
Результат решения.
PS C:\Users\Alex\New_JK\Seminar_02\Task_0202> dotnet run
Our random number is => 762
Our first number is => 7
Our trind number is => 2
Our new number is => 72
*/
// II- вариант
int GetNumber(int num)
{
    Console.Write(num + " => ");
    int num1 = num/100;
    int num2 = num%10;
    int num3 = num1*10+num2;

    return num3;
}
int numRand = new Random().Next(100, 1000);
int result = GetNumber(numRand);
Console.WriteLine(result);
/*Результат решения.
PS C:\Users\Alex\New_JK\Seminar_02\Task_0202> dotnet run
454 => 44
PS C:\Users\Alex\New_JK\Seminar_02\Task_0202> dotnet run
*/