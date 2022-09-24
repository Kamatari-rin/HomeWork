// Задача №1
// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Random rnd = new Random();
int[,] array = ArrayFilling(new int[rnd.Next(3, 3), rnd.Next(3, 3)]);
int[] arrayStringSum = new int[array.GetLength(0)];
int arrayStringMin = 1;


int[,] ArrayFilling(int[,] array) {
    
    for(int i = 0; i < array.GetLength(0); i++) {
        
        for(int j = 0; j < array.GetLength(1); j++) {

            array[i, j] = rnd.Next(10, 100);
            
        }
    }

    return array;
}

int[,] ArrayPrint(int[,] array) {
    
    for(int i = 0; i < array.GetLength(0); i++) {
        
        for(int j = 0; j < array.GetLength(1); j++) {

            Console.Write(array[i, j] + "\t");
            
        }
        Console.WriteLine();
    }
    return array;
}

int[] ArrayStringSum(int[,] array) {

    for(int i = 0; i < array.GetLength(0); i++) {

        for(int j = 0; j < array.GetLength(1); j++) {

            arrayStringSum[i] += array[i, j];

        }

    }
    return arrayStringSum;
}

int ArrayStringMin(int[] array) {
    
    int buf = array[0];
    for(int i = 0; i < array.Length; i++) {

        if(array[i] < buf) {

            buf = array[i];
            arrayStringMin = i + 1;

        }

    } 
    
    return arrayStringMin;

}

ArrayPrint(array);
ArrayStringSum(array);

Console.WriteLine();

Console.WriteLine(string.Join("\t", arrayStringSum));

Console.WriteLine();

Console.WriteLine($"Строка {ArrayStringMin(arrayStringSum)} является той, в которой сумма всех эллементов наименьшия");