// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массив.

 Console.Clear();
void Method1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] a1 = new int [8];
Console.WriteLine();
for (int i = 0; i < a1.Length; i++)
{
    a1[i] = new Random().Next(-9, 9);
}
Method1(a1);
int a = 7;
bool b = false;
for (int i = 0; i < a1.Length; i++)
{
    if (a == a1[i]) b = true;
}
if (b == true)  Console.WriteLine($"В массиве присутвует число {a} ");
else
{
    Console.WriteLine($"В массиве не присутвует число {a} ");
}