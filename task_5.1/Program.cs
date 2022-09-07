// Задача №1 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void TaskOne()
{
    Console.WriteLine("Задача №1: ");
    Console.WriteLine(" ");

    Random rnd = new Random();

    int arrayLength = rnd.Next(1000);
    int[] array = new int[arrayLength];
    int evenCount = 0;

    for(int i = 0; i < array.Length; i++) {

        array[i] = rnd.Next(100, 1000);
        
    }

    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) {
            evenCount++;
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine(evenCount);
}
// Вывод ответа
TaskOne();
Console.WriteLine(" ");


// Задача №2 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
void TaskTwo()
{
    Console.WriteLine("Задача №2: ");
    Console.WriteLine(" ");

    Random rnd = new Random();

    int arrayLength = rnd.Next(1000);
    int[] array = new int[arrayLength];
    int evenSum = 0;

    for(int i = 0; i < array.Length; i++) {

        array[i] = rnd.Next(1, 1000);
        
    }

    for(int i = 2; i < array.Length; i += 2){
        if(array[i] % 2 == 0) {
            evenSum += array[i];
        }
    }
    
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine(" ");
    Console.WriteLine($"Сумма четных элементов, стоящих на четных позициях в массиве равно {evenSum}.");
}
// Вывод ответа
TaskTwo();
Console.WriteLine(" ");

// Задача №3
// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void TaskThree()
{
    Console.WriteLine("Задача №3: ");
    Console.WriteLine(" ");

    Random rnd = new Random();

    int arrayLength = rnd.Next(1000);
    int[] array = new int[arrayLength];
    
    for(int i = 0; i < array.Length; i++) {

        array[i] = rnd.Next(1, 1000);
        
    }

    int arrayMax = array[0];
    int arrayMin = array[0];
    
    for(int i = 0; i < array.Length; i++){
        
        if(arrayMax < array[i]) {
            arrayMax = array[i];
        }
        if(arrayMin > array[i]) {
            arrayMin = array[i];
        }
    }

    int arrayDif = arrayMax - arrayMin;
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine(" ");
    Console.WriteLine($"Разница между максимальными и минимальным элементом в массиве равна {arrayDif}.");
}
// Вывод ответа
TaskThree();
Console.WriteLine(" ");