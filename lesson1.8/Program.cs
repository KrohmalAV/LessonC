Console.Clear();
int x1 = 1, y1 = 18,
    x2 = 36, y2 = 1,
    x3 = 72, y3 = 18;
Console.SetCursorPosition(x1, y1);
Console.WriteLine("*");
Console.SetCursorPosition(x2, y2);
Console.WriteLine("*");
Console.SetCursorPosition(x3, y3);
Console.WriteLine("*");
int count = 0;
int x = x1, y = y1;
while(count < 10000)
{
    int t = new Random().Next(1,4);
    if(t == 1)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }
    if(t == 2)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }
    if(t == 3)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}