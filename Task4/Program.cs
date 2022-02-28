System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i = i + 2)
{
    System.Console.Write(i + " ");
}
