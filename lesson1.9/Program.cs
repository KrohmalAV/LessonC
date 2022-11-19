Console.Clear();
/* для случая когда данные введены пользователем с клавиатуры:
Console.Write("Введите изначальное расстояние между друзьями в метрах: ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость движения первого друга: ");
int speedfriend1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость движения второго друга: ");
int speedfriend2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость движения собаки: ");
int speeddog = Convert.ToInt32(Console.ReadLine());
*/
int distance = 10000;
int speedfriend1 = 1;
int speedfriend2 = 2;
int speeddog = 5;

int count = 0;
int friend = 2;
int time = 0;

while(distance > 5)
{
    if (friend == 1)
    {
        time = distance / (speedfriend1 + speeddog);
        friend = 2;
    }
    else
    {
        time = distance / (speedfriend2 + speeddog);
        friend = 1;
    }
    distance = distance - (speedfriend1 + speedfriend2) * time;
    count++;
}
Console.Write("Собака пробежит от одного друга к другому ");
Console.Write(count);
Console.WriteLine(" раз");