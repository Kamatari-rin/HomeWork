// Точка входа 
class Program 
{
    static void Main(string[] args)
    {
        var readerWriter = new ConsoleReadWriter();
        var logic = new MainScenarios(readerWriter);
        logic.Start();
        Console.ReadKey();
    }
}
////////////////////////////////////////////////////////////////////////////////////////////////////

// Создаем класс для того что бы сделать из точки отдельный объект, которым мы будет оперировать.
public class Point3D 
{
    // Обявляем переменные в которых будут храниться значения точек, значение данных переменных мы будем получать с помощью метода
    // get который будет получать значения переменных из функции ReadPoint3D.
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
////////////////////////////////////////////////////////////////////////////////////////////////////

// Создаем класс в котором будет проводить математические операции.
public static class Point3DMath
{
    // Создаем функцию Distance() которая будет расчитывать расстояние между двумя точками.
    public static double Distance(Point3D p1, Point3D p2)
    {
        return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X)
                    + (p1.Y - p2.Y) * (p1.Y - p2.Y)
                    + (p1.Z - p2.Z) * (p1.Z - p2.Z));
    }
}
////////////////////////////////////////////////////////////////////////////////////////////////////

// Создаем класс в котором будут описан функционал для считывания точек из консоли.
public interface ReaderWriter
{
    Point3D Read3DPoint();
    string ReadLine();
    void WriteLine(string line);
}

public class ConsoleReadWriter : ReaderWriter
{
    // Создаем функцию для считывания координаты точки, значения будем передавать в функцию Read3DScenario(),
    // которая будет сохранять три координаты в массив, тем самым делая из точки отдельный объект,
    // и уже этот объект мы будем передавать в функцию Point3DMath() для математических вычислений.
    public Point3D Read3DPoint() // Создаем функцию Read3DPoint()
    {
        Console.Write("Введите координаты x: "); //Выводим в консоль  - "Введите координаты x: ".
        var x = Convert.ToDouble(Console.ReadLine()); // создаем переменную x, значение будем считывать с помощью Console.ReadLine(), а так же сразу конвертировать строку в число с плавующей точкой с помощью ToDouble().
        Console.Write("Введите координаты y: ");  
        var y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты z: ");  
        var z = Convert.ToDouble(Console.ReadLine());

        return new Point3D(x, y, z); // Данная функция будет возвращать введенные пользователем значения x, y, z в double формате.
    }

    public void WriteLine(string line)
    {
        Console.WriteLine(line);
    }

    public string ReadLine()
    {
        return Console.ReadLine();
    }
}
////////////////////////////////////////////////////////////////////////////////////////////////////

// Создаем класс в котором прописываем сценарий работы с программой.
public class MainScenarios 
{
    private readonly ReaderWriter p_readerWriter;

    public MainScenarios(ReaderWriter readerWriter)
    {
        p_readerWriter = readerWriter;
    }

    public void Start()
    {
        p_readerWriter.WriteLine("Нахождение расстояния между двумя точками в пространстве.");

        Read3DScenario();
    }

    private void Read3DScenario()
    {
        p_readerWriter.WriteLine("Введите координаты первой точки: "); // Выводим в консоль "Введите координаты первой точки: ".
        var p1 = p_readerWriter.Read3DPoint(); // Создаем переменную для хранения координат первой точки, данная переменная будет получать значения из функции Read3DPoint().
        p_readerWriter.WriteLine("Введите координаты второй точки: ");
        var p2 = p_readerWriter.Read3DPoint();
        
        var distance = Point3DMath.Distance(p1, p2); // Создаем переменную в которой будет храниться результат вычислений.

        p_readerWriter.WriteLine($"Расстояние между этими двумя точками в пространстве равно {distance}"); // Выводим в консоль результат.
    }
}