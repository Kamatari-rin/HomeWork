// Задача №2
// Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// 18 20
// 15 18

// 2 * 3 + 4 * 3
// 3 * 3 + 2 * 3
// 2 * 4 + 4 * 3

int[,] arrayOne = new int[2, 2] {{2, 4}, 
                                 {3, 2}};

int[,] arrayTwo = new int[2, 2] {{3, 4}, 
                                 {3, 3}};

int[,] ArrayProdact (int[,] arrayOne, int[,] arrayTwo) {

        int[,] rezultProdact = new int[2, 2];

        rezultProdact[0, 0] = arrayOne[0, 0] * arrayTwo[0, 0] + arrayOne[0, 1] * arrayTwo[1, 0];
        rezultProdact[1, 0] = arrayOne[1, 0] * arrayTwo[0, 0] + arrayOne[1, 1] * arrayTwo[1, 0];

        rezultProdact[0, 1] = arrayOne[0, 0] * arrayTwo[0, 1] + arrayOne[0, 1] * arrayTwo[1, 1];
        rezultProdact[1, 1] = arrayOne[1, 0] * arrayTwo[0, 1] + arrayOne[1, 1] * arrayTwo[1, 1];

        return rezultProdact;

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

int[,] rezult = ArrayProdact (arrayOne, arrayTwo);

ArrayPrint(rezult);

