// Задача №1 
// Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void TaskOne()
{
    Console.WriteLine("Задача №1: ");
    Console.WriteLine(" ");
    Console.Write("Введите любое целое число отличное от нуля: ");
    // string[] = readNums = Console.ReadLine().Split();
    int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int Count = 0;

    for(int i = 0; i < number.Length; i++) {

        if(number[i] > 0){
            Count++;
        }
        
    }
    Console.WriteLine(" ");
    Console.WriteLine(Count);
}
// Вывод ответа
TaskOne();
Console.WriteLine(" ");

// Задача №3
// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.

// 1, 3, 8, 3, 2 -> 11

void TaskThree()
{
    Console.WriteLine("Задача №3: ");
    Console.WriteLine(" ");
    Random rnd = new Random();

    int arrayLength = rnd.Next(1000);
    int[] array = new int[arrayLength];
    int sum = 0;
    
    for(int i = 0; i < array.Length; i++) {

        array[i] = rnd.Next(1, 1000);
        
    }

    if(array.Length % 2 == 0) {
        
        int a = array.Length / 2;
        
        for(int i = 0; i < a; i++) {
            
            int bufProduct = 0;
            bufProduct = array[i] * array[array.Length - 1 - i];
            sum += bufProduct; 

            }
    } else {

        int center = array[array.Length / 2];
        int indexCenter = Array.IndexOf(array, center);

        array[indexCenter] = 0;

        int a = (array.Length + 1) / 2;
        
        for(int i = 0; i < a; i++) {

            int bufProduct = 0;
            bufProduct = array[i] * array[array.Length - 1 - i];
            sum += bufProduct; 

        }
    }

    Console.WriteLine(" ");
    Console.WriteLine(sum);
}
// Вывод ответа
TaskThree();
Console.WriteLine(" ");
