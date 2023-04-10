// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateArray(int Length)
{
int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(100,1000);
}
return numbers;
}

void PrintArray(int [] numbers)
{
System.Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
System.Console.Write(numbers[i] + "; ");
}
System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

int Num (string arg)
{
System.Console.WriteLine($"Введите {arg} ");
return int.Parse(System.Console.ReadLine());
}

int EvenQty (int [] numbers)
{
int qty = 0;
for (int i = 0; i < numbers.Length; i++)
{
if(numbers[i] % 2 == 0)
{
    qty++;
}
}
return qty;
}

int Length = Num("длину массива");
int [] numbers = CreateArray(Length);
PrintArray(numbers);
System.Console.WriteLine(EvenQty(numbers));