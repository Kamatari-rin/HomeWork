// Задача №1

void TaskOne()
{
    Console.Write("Введите любое целое число отличное от нуля: ");
    int number = Int32.Parse(Console.ReadLine());
    int reversNumber = 0;
    int buf = number;

    while (buf != 0)
    {
        int remainder;
        buf = Math.DivRem(buf, 10, out remainder);
        reversNumber = reversNumber * 10 + remainder;
    }
    
    if (number == reversNumber) {
        Console.WriteLine($"Число {number} является палиндромом.");
    } else {
        Console.WriteLine($"Число {number} не является палиндромом.");
    }

    Console.WriteLine(reversNumber);
    Console.WriteLine(number);
}

//Вывод ответа
TaskOne();
Console.WriteLine(" ");


