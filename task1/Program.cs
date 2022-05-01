// See https://aka.ms/new-console-template for more information

void Print(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int [] mass = new int [12];

Print(mass);

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}

Print(mass);

int summPos = 0;
int summNeg = 0;

for (int i = 0; i < mass.Length; i++)
{
    if(mass[i] > 0)
    {
        summPos += mass[i];
    }
    else                                          //(mass[i] < 0)
     {
        summNeg += mass[i];
     }
}
Console.WriteLine($"Сумма положительнфх чисел {summPos} и трицательных чисел {summNeg}");