int[] array = {1, 7, 6, 4, 5, 6, 7, 8, 9};
int n = array.Length;
int i = 0;
int find = 7;
while(i < n)
{
    if(array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}