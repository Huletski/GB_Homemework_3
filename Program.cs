//task1 Найти кубы чисел от 1 до N:
/*
Console.WriteLine("Please, enter number:");
int number = int.Parse(Console.ReadLine());


   int i = 1;
    while (i <= number)
    {
    int result = i * i * i;
    Console.Write("Result:");
    Console.WriteLine($" {i}^3= {result}");
    i++;
    }

*/





// task2 Подсчитать сумму цифр в числе
/*
int num = ReadingEntrance("Please, Enter Number: ");
int Len = PlusingInt(num);
SumOfNumbers(num, Len);

int ReadingEntrance(string message)
{
   Console.WriteLine(message);
   return int.Parse(Console.ReadLine());
}

int PlusingInt(int a)
{
   int index = 0;
   while (a >0)
   {
      a = a / 10;
      index++;
      
   }
   return index;
}

void SumOfNumbers(int n, int len)
{
   int sum = 0;
   for (int i = 1; i <= len; i++)
   {
      sum = sum + n % 10;
      n = n / 10;
   }
   Console.WriteLine(sum);
}

*/





//task3 Написать программу вычисления произведения чисел от 1 до N

/*
Console.WriteLine("Please, enter number:");
int number = int.Parse(Console.ReadLine());

int result = 1;
int count = 1;
for ( ;count <= number;)
 {
    result = count*result;
    count++;
 }

Console.WriteLine($"Product of numbers from 1 to {number}: {result}");

*/






//task4 Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Please, enter number:");
int numer = int.Parse(Console.ReadLine());

int z = 1;
while (z <= numer)
{
  if (z % 2 == 0)
  {
   int result = z * z * z;
   Console.WriteLine($"{z}^3 = {result} ");
  }
  z++;
}

