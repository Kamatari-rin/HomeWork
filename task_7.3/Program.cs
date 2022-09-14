// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Задача №3
Random rnd = new Random();
int[,] array = new int[3, 3];

Console.WriteLine("Задача №3: ");
Console.WriteLine();

for(int i = 0; i < array.GetLength(0); i++) {
    
    for(int j = 0; j < array.GetLength(1); j++) {

        array[i, j] = rnd.Next(10, 100);
        Console.Write(array[i, j] + "\t");
        
    }
    Console.WriteLine();
}

double columnAvg(int[,] array, int columnIndex) {

    double columnSum = 0;
    for(int i = 0; i < array.GetLength(0); i++) {

        columnSum += array[i, columnIndex];

    }

    double columnAvg = columnSum / array.GetLength(0);

    return columnAvg;
}

Console.WriteLine();

double[] avg = new double[array.GetLength(1)];

for(int i = 0; i < array.GetLength(1); i++){

    avg[i] = Math.Round(columnAvg(array, i), 1);

}

Console.WriteLine(string.Join("\t", avg));