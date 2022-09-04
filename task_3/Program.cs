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


//Задача №2
void TaskTwo()
{

    Console.WriteLine("Введите координаты первой точки: ");

    Console.Write("Введите координаты x: "); 
    var x1 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Введите координаты y: ");  
    var y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты z: ");  
    var z1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Введите координаты второй точки: ");

    Console.Write("Введите координаты x: "); 
    var x2 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Введите координаты y: ");  
    var y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты z: ");  
    var z2 = Convert.ToDouble(Console.ReadLine());

    double rezult = Math.Sqrt((x2 - x1) * (x2 - x1)
                     + (y2 - y1) * (y2 - y1)
                     + (z2 - z1) * (z2 - z1));
    
    Console.WriteLine($"Расстояние между двумя точками равно {rezult}");
    
}
//Вывод ответа
TaskTwo();
Console.WriteLine(" ");

//Задача №3
void TaskThree()
{
    Console.WriteLine("Задача №3: ");
    Console.WriteLine("Введите любое целое число");
    var number = Convert.ToInt32(Console.ReadLine());

    double[] arrayCubedNumbers = new double[number];

    for(int i = 0; i < number; i++){
        arrayCubedNumbers[i] = Math.Pow(i + 1, 3);
    } 
    
    Console.WriteLine(string.Join(", ", arrayCubedNumbers));
}
//Вывод ответа
TaskThree();
Console.WriteLine(" ");


