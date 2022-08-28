// Задача 1
int[] twoNumbers = {
    5, 7, 
    2, 10, 
    -9, -3
};

Console.WriteLine("Задача №1:");
if (twoNumbers[0] > twoNumbers[1]) {
    Console.WriteLine( $"   Пример 1: - Максимальным числом является {twoNumbers[0]}, а минимальным число {twoNumbers[1]}." );
}
else {
    Console.WriteLine( $"   Пример 1: - Максимальным числом является {twoNumbers[1]}, а минимальным число {twoNumbers[0]}." );
}

if (twoNumbers[2] > twoNumbers[3]) {
    Console.WriteLine( $"   Пример 2: - Максимальным числом является {twoNumbers[2]}, а минимальным число {twoNumbers[3]}." );
}
else {
    Console.WriteLine( $"   Пример 2: - Максимальным числом является {twoNumbers[3]}, а минимальным число {twoNumbers[2]}." );
}

if (twoNumbers[4] > twoNumbers[5]) {
    Console.WriteLine( $"   Пример 3: - Максимальным числом является {twoNumbers[4]}, а минимальным число {twoNumbers[5]}." );
}
else {
    Console.WriteLine( $"   Пример 3: - Максимальным числом является {twoNumbers[5]}, а минимальным число {twoNumbers[4]}." );
}

Console.WriteLine(" ");

// Задача 2
Console.WriteLine("Задача №2:");
int[] threeNumbers = {
        2, 3, 7,
        44, 5, 78,
        22, 3, 9
    };
int max1 = threeNumbers[0];
int min1 = threeNumbers[0];

int max2 = threeNumbers[3];
int min2 = threeNumbers[3];

int max3 = threeNumbers[6];
int min3 = threeNumbers[6];

for (int i = 1; i < 3; i++) {
    if (threeNumbers[i] > max1)
        max1 = threeNumbers[i];
    if (threeNumbers[i] < min1)
        min1 = threeNumbers[i];
}   
for (int i = 3; i < 6; i++) {
    if (threeNumbers[i] > max2)
        max2 = threeNumbers[i];
    if (threeNumbers[i] < min2)
        min2 = threeNumbers[i];
}  
for (int i = 6; i < 9; i++) {
    if (threeNumbers[i] > max3)
        max3 = threeNumbers[i];
    if (threeNumbers[i] < min3)
        min3 = threeNumbers[i];
}    
Console.WriteLine( 
    $"  Пример 1: - Максимальным числом является {max1}, а минимальным число {min1}.\n" +
    $"  Пример 2: - Максимальным числом является {max2}, а минимальным число {min2}.\n" +
    $"  Пример 3: - Максимальным числом является {max3}, а минимальным число {min3}."
);

Console.WriteLine(" ");

// Задача 3
Console.WriteLine("Задача №3:");

int[] evenNumber = {4, -3, 7};

for (int i = 0; i < 3; i++) {
    int buf = Math.Abs(evenNumber[i] % 2);
        if(buf == 1) {
            Console.WriteLine($"    Число {evenNumber[i]} является не четным.");
        } else {
            Console.WriteLine($"    Число {evenNumber[i]} является четным.");
        }
}

Console.WriteLine(" ");

// Задача 4
Console.WriteLine("Задача №4:");

int[] allEvenNumber = {5, 8};

for (int i = 1; i < allEvenNumber[0] + 1; i++) {
    int buf = i % 2;
        if (buf == 0) {
            Console.WriteLine($"    {i},");
        }
}

Console.WriteLine(" ");

// Задача 4 убрал запятую
Console.WriteLine("Задача №4 (доработанная):");

int[] result = new int[2];

for (int i = 0, even = 1; even < allEvenNumber[0] + 1; even++) {

    int buf = even % 2;
        if (buf == 0) {
            result[i] = even;
            i++;
        }
}
Console.WriteLine(string.Join(", ", result));