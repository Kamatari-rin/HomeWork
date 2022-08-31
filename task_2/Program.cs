using System;


// Задача №4 (Предыдущие домашние задание. Задача №4 - Доработанная)
void Even()
{
        Console.Write("Задача №4 (Из предыдущего ДЗ): ");

        int[] allEvenNumber = {5, 8};
        int[] result = new int[2];

        for (int i = 0, even = 1; even < allEvenNumber[0] + 1; even++) {

            int buf = even % 2;
                if (buf == 0) {
                    result[i] = even;
                    i++;
                }
        }
        Console.WriteLine(string.Join(", ", result));
}

//Вывод ответа
Even();
Console.WriteLine(" ");

// Задача №1
void TaskOne()
{
    Console.Write("Задача №1: ");

    Random rnd = new Random();

    int value = rnd.Next(100, 999);

    Console.WriteLine(value);
}

//Вывод ответа
TaskOne();
Console.WriteLine(" ");


// Задача №2
void TaskTwo()
{
    Console.Write("Задача №2: ");

    Random rnd = new Random();

    int value = rnd.Next(1, 655);

    if (value < 100) {
        Console.WriteLine("Такой цифры нет!");
    } else {
        Console.WriteLine(value.ToString()[2]);
    }
}

//Вывод ответа
TaskTwo();
Console.WriteLine(" ");

// Задача №3
void TaskThree()
{
    Console.Write("Задача №3: ");

    Random rnd = new Random();

    int value = rnd.Next(0, 7);

    string[] week = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

    if (value == 5 | value == 6) {
        Console.WriteLine($"{week[value]} является выходным днем");
    } else {
        Console.WriteLine($"{week[value]} является рабочим днем");
    }
}
// Вывод ответа
TaskThree();
Console.WriteLine(" ");

// Задача №4
void TaskFour()
{
    Console.Write("Задача №4: ");

    Random rnd = new Random();

    int value = rnd.Next(1, 1000000);

    if (value % 7 == 0 & value % 23 == 0) {
        Console.WriteLine($"Число {value} одновременно кратно 7 и 23");
    } else {
        Console.WriteLine($"Число {value} не подходит. (Не кратно 7 и 23 одновременно)");
    }
}

// Вывод ответа
TaskFour();
Console.WriteLine(" ");

