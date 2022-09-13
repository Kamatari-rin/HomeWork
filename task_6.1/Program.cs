using System;

// Задача №2
// Считываем координаты с консоли
Console.Write("Введите координаты первой прямой: ");
Console.Write("Введите координаты первой точки сначало по оси x, затем по оси y: ");
Point pABDot1 = new Point(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())); 
Console.Write("Введите координаты второй точки сначало по оси x, затем по оси y: ");
Point pABDot2 = new Point(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())); 
        
Console.WriteLine(" ");

Console.Write("Введите координаты второй прямой: ");
Console.Write("Введите координаты первой точки сначало по оси x, затем по оси y: ");
Point pCDDot1 = new Point(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())); 
Console.Write("Введите координаты второй точки сначало по оси x, затем по оси y: ");
Point pCDDot2 = new Point(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())); 
        
// Решаем уравнение прямой x(y2 - y1) + y(x1 - x2) - x1y2 + y1x2 = 0, для этого разобьем уравнение на коэффиценты
// и введем по переменной для каждого a = (y2 - y1), b = (x1 - x2), c = (-x1y2 + y1x2).

    int a1 = pABDot2.Y - pABDot1.Y;
    int b1 = pABDot1.X - pABDot2.X;
    int c1 = -pABDot1.X * pABDot2.Y + pABDot1.Y * pABDot2.X;

    int a2 = pCDDot2.Y - pCDDot1.Y;
    int b2 = pCDDot1.X - pCDDot2.X;
    int c2 = -pCDDot1.X * pCDDot2.Y + pCDDot1.Y * pCDDot2.X;

// Добавим проверку на параллельность и на совпадение прямых.
if ((a1 * b2 - a2 * b1) == 0) {
        
    Console.WriteLine("Прямые параллельны другу друг и не имеют точек пересечения");
        
    if (a1 * b2 == b1 * a2 && a1 * c2 == a2 * c1 && b1 * c2 == c1 * b2) {

        Console.WriteLine("Прямые совпадают и имеют бесконечное количество решений");
    }
}   

// Находим точку пересечения решая уравнения
// x = (-b1y - c1) / a1
// y = (-a2x - c2) / b2
// Упростим
// x = (b1c2 - b2c1) / (b2a1 - b1a2)
// y = (a1c1 - a1c2) / (a1b2 - a1b1)

Point pCross = new Point();
pCross.X = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
pCross.Y = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);

Console.WriteLine(" ");
Console.WriteLine(pCross);
