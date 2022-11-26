int Max (int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if (arg2 > resalt) resalt = arg2;
    if (arg3 > resalt) resalt = arg3;
    return resalt;
}

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
/* она строчка массива заменяет 9 строчек с переменными
int a1 = 23;
int a2 = 33;
int a3 = 43;
int b1 = 53;
int b2 = 63;
int b3 = 73;
int c1 = 2222;
int c2 = 3500;
int c3 = 48;
int max = a1;
*/

/* Используя метод, заданный в самом начале, мы сможем 8 строчек условий сократить до 4
if (a2 > max) max = a2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (b2 > max) max = b2;
if (b1 > max) max = b1;
if (c3 > max) max = c3;
if (c2 > max) max = c2;
if (c1 > max) max = c1;
*/
/* Можно используя метод в методе сократить эти 4 строчки до 1
int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3);
int max = Max(max1, max2, max3);
*/
/* А теперь аргументы метода зададим через массив:
int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));
*/
int max = Max(Max(array[0], array[1], array[2]),
          Max(array[3], array[4], array[5]),
          Max(array[6], array[7], array[8]));
Console.WriteLine(max);