// Задача №3  Назовём число «интересным» если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 

// Console.WriteLine("Задача №3: ");
Console.WriteLine("Введите количество интересных чисел которое вы хотите получить: ");
int n = Convert.ToInt32(Console.ReadLine());
int nLength = numLength(n);
int[] array = new int[n];
Random random = new Random();

// Заполняем массив интересными цифрами
for(int i = 0, count = 20; 1 > array[n - 1]; count++) {

    int[] breakNum = breakNumber(count);
    bool interesting = interestingNumOrNot(breakNum);
    if(interesting == true) {
        array[i] = count;
        i++;
    } 
}
// Перемешиваем получившийся массив
int[] mixArray(int[] interestingArray)
{   

    int[] mixArray = interestingArray; 
    
    for(int i = 0; i < array.Length; i++) {
        
        int j = random.Next(i + 1);
        var tmp = mixArray[j];
        mixArray[j] = mixArray[i];
        mixArray[i] = tmp;

    } return mixArray;
}

// Выводим массив в консоль
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", mixArray(array)));

// Определяем ялвяется ли число инетересным
bool interestingNumOrNot(int[] breakNum)
{   
    bool interesting = false;
    int numSum = 0;
    int numProduct = 1;

        for(int i = 0; i < breakNum.Length; i++) {
            numSum += breakNum[i];
            numProduct *= breakNum[i];
        }

        if(numProduct % numSum == 0 && numProduct != 0) {
            interesting = true;
        }
    
    return interesting;
}

// Разбиваем число на цифры и возвращаем их в массиве
int[] breakNumber(int number) {
    int[] breakNum = new int[numLength(number)];
    for(int buf = number, i = 0; buf != 0; i++) {
        buf = Math.DivRem(buf, 10, out breakNum[i]);
    } return breakNum;
}

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