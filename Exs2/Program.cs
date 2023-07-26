
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение k1: ");
            double k1;
            while (!double.TryParse(Console.ReadLine(), out k1))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }

            Console.Write("Введите значение b1: ");
            double b1;
            while (!double.TryParse(Console.ReadLine(), out b1))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }

            Console.Write("Введите значение k2: ");
            double k2;
            while (!double.TryParse(Console.ReadLine(), out k2))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }

            Console.Write("Введите значение b2: ");
            double b2;
            while (!double.TryParse(Console.ReadLine(), out b2))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }

            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
        }
    }
