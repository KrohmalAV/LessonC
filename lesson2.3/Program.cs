Console.Clear();
void FillArray(int[]collection)
{
    int length = collection.Length;
    int i = 0;
    while(i < length)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}
void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
} 
int IndexOf(int[]collect, int find)
{
    int count = collect.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collect[index] == find)
        {
            position = index;
            break;
        }
    index++;
    }
    return position;
}

int[] array = new int[10];
Console.Write("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());
FillArray(array);
Console.Write("В массиве: ");
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, find);
if(pos == -1) Console.WriteLine($"{find} нет в массиве");
else Console.WriteLine($"ближайшее число {find} находится на {pos} позиции");