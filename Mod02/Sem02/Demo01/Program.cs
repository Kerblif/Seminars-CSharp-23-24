namespace Demo01
{
    public class Polygon
    {
        private int _numberOfSides; // Количество сторон.
        private double _radius; // Радиус вписанной окружности.

        public Polygon(int numberOfSides = 5, double radius = 13.5)
        {
            _numberOfSides = numberOfSides;
            _radius = radius;
        }

        // Свойство для получения периметра.
        public double Perimeter => 2 * _numberOfSides * _radius * Math.Tan(Math.PI / _numberOfSides);

        // Свойство для получения площади.
        public double Area => Perimeter * _radius / 2;

        public string PolygonData()
        {
            return $"N = {_numberOfSides}; R = {_radius:F3}; P = {Perimeter:F3}; S = {Area:F3}";
        }

        public void EnLarge(int k) // Увеличение полей в k раз.
        {
            _numberOfSides *= k;
            _radius *= k;
        }

        public Polygon Copy() // Копирование многоугольника.
        {
            return new Polygon(_numberOfSides, _radius);
        } 
    }

    class Program
    {
        public static void ReadInt(string message, out int result) // Метод чтения целого числа.
        {
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }

        public static Polygon[] PolygonCopy(Polygon[] polygons) // Метод глубокого копирования массива многоугольников.
        {
            Polygon[] polygonsCopy = new Polygon[polygons.Length];
            for (int i = 0; i < polygons.Length; i++)
            {
                polygonsCopy[i] = polygons[i].Copy();
            }

            return polygonsCopy;
        }
        
        public static void EnlargePolygons(Polygon[] polygons, int k = 2) // Метод увеличения многоугольника в k раз.
        {
            for (int i = 0; i < polygons.Length; i++)
            {
                polygons[i].EnLarge(k);
            }
        }
        public static void PrintPolygons(Polygon[] polygons) // Метод печати многоугольника.
        {
            foreach (var polygon in polygons)
            {
                Console.WriteLine(polygon.PolygonData());
            }
            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        static void Main(string[] args)
        {
            ReadInt("Введите количество элементов массива.", out int n);
            Polygon[] polygons = new Polygon[n];
            Random random = new Random();
            for (int i = 0; i < n; i++) // Заполнение массива случайными многоугольниками.
            {
                int rnd = random.Next(0, 5);
                switch (rnd)
                {
                    case 0: // Заполняется умалчиваемыми аргументами.
                        polygons[i] = new Polygon();
                        continue;
                    case <= 3: // Заполняется заданными аргументами.
                        polygons[i] = new Polygon(random.Next(3, 11), 10 + random.NextDouble() * 40);
                        continue;
                    default: // Радиус задаётся умалчиваемым аргументом.
                        polygons[i] = new Polygon(random.Next(3, 11));
                        break;
                }
            }

            Polygon[] polygonsCopy1 = (Polygon[])polygons.Clone(); // Неглубокое копирование.
            Polygon[] polygonsCopy2 = new Polygon[polygons.Length];
            Array.Copy(polygons, polygonsCopy2, polygons.Length); // Неглубокое копирование.
            Polygon[] polygonsCopy3 = PolygonCopy(polygons); // Глубокое копирование.

            Console.WriteLine("Изменяем 1 копию.");
            EnlargePolygons(polygonsCopy1);
            Console.WriteLine("Изначальный массив:");
            PrintPolygons(polygons);
            Console.WriteLine("Копия 1:");
            PrintPolygons(polygonsCopy1);
            Console.WriteLine("Копия 2:");
            PrintPolygons(polygonsCopy2);
            Console.WriteLine("Копия 3:");
            PrintPolygons(polygonsCopy3);
            
            Console.WriteLine("Изменяем 2 копию.");
            EnlargePolygons(polygonsCopy2);
            Console.WriteLine("Изначальный массив:");
            PrintPolygons(polygons);
            Console.WriteLine("Копия 1:");
            PrintPolygons(polygonsCopy1);
            Console.WriteLine("Копия 2:");
            PrintPolygons(polygonsCopy2);
            Console.WriteLine("Копия 3:");
            PrintPolygons(polygonsCopy3);
            
            Console.WriteLine("Изменяем 3 копию.");
            EnlargePolygons(polygonsCopy3);
            Console.WriteLine("Изначальный массив:");
            PrintPolygons(polygons);
            Console.WriteLine("Копия 1:");
            PrintPolygons(polygonsCopy1);
            Console.WriteLine("Копия 2:");
            PrintPolygons(polygonsCopy2);
            Console.WriteLine("Копия 3:");
            PrintPolygons(polygonsCopy3);
            
            Console.WriteLine("Изменяем изначальный массив.");
            EnlargePolygons(polygons);
            Console.WriteLine("Изначальный массив:");
            PrintPolygons(polygons);
            Console.WriteLine("Копия 1:");
            PrintPolygons(polygonsCopy1);
            Console.WriteLine("Копия 2:");
            PrintPolygons(polygonsCopy2);
            Console.WriteLine("Копия 3:");
            PrintPolygons(polygonsCopy3);
        }
    }
}