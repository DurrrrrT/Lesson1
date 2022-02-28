    System.Console.WriteLine("Введите число: ");
    int number1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число: ");
    int number2 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число: ");
    int number3 = int.Parse(Console.ReadLine());
    if (number1 > number2)
    {
        if (number1 > number3) System.Console.WriteLine("Максимальное число: " + number1);
        else System.Console.WriteLine("Максимальное число: " + number3);
    
    }
    else 
    {
     if (number2 < number3) System.Console.WriteLine("Максимальное число: " + number3);
     else System.Console.WriteLine("Максимальное число: " + number2);
    }

