//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату по x точки A: ");
int Ax = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите координату по y точки A: ");
int Ay = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите координату по z точки A: ");
int Az = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите координату по x точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите координату по y точки B: ");
int By = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите координату по z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine()!);

double AB = Math.Sqrt((Math.Pow((Bx - Ax), 2)) + (Math.Pow((By - Ay), 2)) + (Math.Pow((Bz - Az), 2)));
Console.WriteLine($"Расстояние между точками А и В в 3D пространстве, составляет {AB:f2}");
