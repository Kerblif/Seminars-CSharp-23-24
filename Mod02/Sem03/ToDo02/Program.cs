namespace Program
{
    static public class Program
    {
        public static void Main(string[] args)
        {
            Polygon polygon = new Polygon();
            Console.WriteLine("По умолчанию создан многоугольник: ");
            Console.WriteLine(polygon.PolygonData());
            double rad;
            int number;
            do
            {
                do Console.Write("Введите число сторон: ");
                while (!int.TryParse(Console.ReadLine(), out number) | number < 3);
                do Console.Write("Введите радиус: ");
                while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);
                polygon = new Polygon(number, rad);
                Console.WriteLine("Сведения о многоугольнике:");
                Console.WriteLine(polygon.PolygonData());
                Console.WriteLine("Для выхода нажмите клавишу ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}