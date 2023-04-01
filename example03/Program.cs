//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int ReadInt (string message)
{
     Console.WriteLine($"{message} ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool ValidateNumber (int number)
{
  if (number != 0 )
    {
        return true;
    }
    System.Console.WriteLine ("Введите число отличное от 0");
    return false;
}
  
int N = ReadInt ("Введите число ");
if (ValidateNumber(N))
{
for (int i= 1; i <= N; i++)
{
  Console.Write($"{Math.Pow(i, 3)} ");
}
}

