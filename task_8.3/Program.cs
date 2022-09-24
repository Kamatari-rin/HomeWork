// Задача №3
// Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.
Random rnd = new Random();

int[,] array = new int[3, 3];

int[,] ArrayFilling(int[,] array) {
    
    for(int i = 0; i < array.GetLength(0); i++) {
        
        for(int j = 0; j < array.GetLength(1); j++) {

            array[i, j] = FitValue();
            
        }
    }

    return array;
}

bool FitOrNot(int[,] array, int randomValue) {

    bool fit = true;

    for(int i = 0; i < array.GetLength(0); i++) {
        
        for(int j = 0; j < array.GetLength(1); j++) {

            if (array[i, j] == randomValue) {
                        
                fit = false;

            } 
            
        }
     }

     return fit; 
}   

int FitValue() {

    int fitValue = 0;

    for(int i = 0; i < 1;) {

        int buf = rnd.Next(11, 100);
        bool fitOrNot = FitOrNot(array, buf);
        
        if(fitOrNot != false) {
            fitValue = buf;
            i++;
        }

    } return fitValue;

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

ArrayFilling(array);
ArrayPrint(array);