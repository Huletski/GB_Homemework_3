//task1 Найти кубы чисел от 1 до N:

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
