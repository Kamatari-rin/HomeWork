// Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
// Задача №1
Random rnd = new Random();
double[,] array = new double[10, 10];

Console.WriteLine("Задача №3: ");

for(int i = 0; i < 10; i++) {
    
    for(int j = 0; j < 10; j++) {

        array[i, j] = Math.Round(rnd.NextDouble() * (1.003 + 97.13), 2);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

