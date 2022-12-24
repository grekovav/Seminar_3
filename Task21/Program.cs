// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84  A (7,-5, 0); B (1,-1,9) -> 11.53

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
double getDistance(int userAX, int userAY, int userAZ, int userBX, int userBY, int userBZ)
{
    double result = Math.Sqrt(Math.Pow((userAX - userBX), 2) + Math.Pow((userAY - userBY), 2));
    return result;
}
int userAX = getUserValue("Введите X1 ");
int userAY = getUserValue("Введите Y1 ");
int userAZ = getUserValue("Введите Z1 ");


int userBX = getUserValue("Введите X2 ");
int userBY = getUserValue("Введите Y2 ");
int userBZ = getUserValue("Введите Z2 ");
double distance = getDistance(userAX, userAY, user AZ, userBX, userBY, userBZ);
Console.WriteLine($"Расстояние между точками {Math.Round(distance, 2)}");