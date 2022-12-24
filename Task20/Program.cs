// 20. Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
double getDistance(int userAX, int userAY, int userBX, int userBY)
{
    double result = Math.Sqrt(Math.Pow((userAX - userBX), 2) + Math.Pow((userAY - userBY), 2));
    return result;
}
int userAX = getUserValue("Введите X1 ");
int userAY = getUserValue("Введите Y1 ");

int userBX = getUserValue("Введите X2 ");
int userBY = getUserValue("Введите Y2 ");
double distance = getDistance(userAX, userAY, userBX, userBY);
Console.WriteLine($"Расстояние между точками {distance}");