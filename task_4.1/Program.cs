// Задача №2  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа.
Console.WriteLine("Задача №2: ");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberLength = numLength(number);
int divSum = 0;

// Считаем количество цифр в числе
int numLength(int number)
{
    int numberLength = 0;
    for(int buf = number; buf != 0;) {     
        buf /= 10;
        numberLength++;
    }
    return numberLength;
}

// Проверяем является ли число делителем
int numDiv(int num, int divider)
{   
    if(divider != 0 && num % divider == 0) {
       return divider;
    }  else return divider = 0;     
}

// Находим сумму делителей
void numSum() 
{
    for(int i = 0, buf = number; i <numberLength && buf != 0; i++) {

        int remainder = 0;

        buf = Math.DivRem(buf, 10, out remainder);

        int divider = numDiv(number, remainder);
        
        divSum += divider;
    }
    Console.WriteLine($"Сумма всех чисел в числе {number} которые являются его делителями равна {divSum}.");
}
numSum();
