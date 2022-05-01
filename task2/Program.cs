// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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
for (int i = 0; i < a1.Length; i++)
{
    a1[i] = -a1[i];
}
Method1(a1);