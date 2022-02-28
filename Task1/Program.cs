System.Console.WriteLine("Введите число: "); 
string a = Console.ReadLine();
System.Console.WriteLine("Введите число: "); 
string b = Console.ReadLine();
if (int.Parse(a) > int.Parse(b))
{
System.Console.WriteLine($"Число {a} больше числа {b} ");
}
else
 if (int.Parse(a) == int.Parse(b)) System.Console.WriteLine("Числа равны" );
else
{
   System.Console.WriteLine($"Число {b} больше числа {a} "); 
}
