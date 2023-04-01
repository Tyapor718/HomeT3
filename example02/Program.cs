//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int ReadInt(string message)
{
    Console.WriteLine($"{message} ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int x1 = ReadInt("Введите координаты x первой точки");
int y1 = ReadInt("Введите координаты y первой точки");
int z1 = ReadInt("Введите координаты z первой точки");
int x2 = ReadInt("Введите координаты x второй точки");
int y2 = ReadInt("Введите координаты y второй точки");
int z2 = ReadInt("Введите координаты z второй точки");
int a1 = x2 - x1;
int b1 = y2 - y1;
int c1 = z2 - z1;
double lenght = Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2) + Math.Pow(c1, 2));
Console.WriteLine($"{Math.Round(lenght, 3)} ");