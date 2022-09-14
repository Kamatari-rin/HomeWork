// Задача №2
Random rnd = new Random();
double[,] array = new double[10, 9];

Console.WriteLine("Задача №3: ");

for(int i = 0; i < 10; i++) {
    
    for(int j = 0; j < 9; j++) {

        array[i, j] = Math.Round(rnd.NextDouble() * (1.003 + 97.13), 2);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Введите номер строки: ");
int y = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите номер столбца: ");
int x = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine();

if(x < array.GetLength(1) && y < array.GetLength(0)) {
    
    Console.WriteLine(array[y, x]);

} else Console.WriteLine("Такого элемента не существует");