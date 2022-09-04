// Задача с семинара
// Напишите программу, которая принимает на вход целое число и выдает количество цифр в числе,
// которые больше среднего арифметического среди всех цифр этого числа
// 1256 -> 2
// 45234 -> 3

void TaskSeminar()
{
    Console.WriteLine("Задача №4: ");
    Console.WriteLine("Введите любое челое число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int numberLength = 0;
    int numberSum = 0;
    int count = 0;
    

// Находим количество цифр в числе
    for(int buf = number; buf != 0;) 
    {
        buf = buf / 10;
        numberLength++;
    }
    
// Находим сумму всех чисел
    for(int buf = number; buf != 0;) {
        int remainder;
        buf = Math.DivRem(buf, 10, out remainder);
        numberSum = numberSum + remainder;
    }
// Находим среднее арифметическое
    double avg = numberSum / numberLength;

// Находим количество цифр которые больше среднего арифметического
    for(int buf = number, remainder; buf !=0;) {
        remainder = buf % 10;
            if (remainder > avg) {
                count++;
            }
        buf = buf / 10;
    }
    Console.WriteLine(count);
}
TaskSeminar();

// Задача №1
void TaskOne()
{
    Console.WriteLine("Задача №1: ");

    Console.WriteLine("Ввеодите число А: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввеодите число В: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    
    int rezult = numberA;

    for(int i = 1; i < numberB; i++) {

        rezult = rezult * numberA;
        
    }
    Console.WriteLine($"    Число {numberA} в степени {numberB} будет {rezult}");
}
// Вывод ответа
TaskOne();
Console.WriteLine(" ");




