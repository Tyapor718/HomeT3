//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int ReadInt (string message)
{
     Console.WriteLine($"{message} ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool ValidateNumber (int number)
{
    if (number < 99999 && number >-99999)
    {
        return true;
    }
    System.Console.WriteLine ("Вы ввели не пятизначное число");
    return false;
}
int N = ReadInt ("Введите пятизначное число");
int X= N/10000;
int Y= N/10%10;
int Z= N/1000%10;
if (ValidateNumber(N))
{
    if (N%10 == X && Y == Z)
    {
        System.Console.WriteLine ("Вы ввели полиндром");
    }
    else 
    {
        System.Console.WriteLine ("Вы ввели не полиндром");
    }
}