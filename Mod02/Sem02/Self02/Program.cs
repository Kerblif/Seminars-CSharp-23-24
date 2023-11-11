namespace Self02
{
    public class VideoFile
    {
        private string _name;
        private int _duration;
        private int _quality;

        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        public int Size => _duration * _quality;

        public string GetInfo()
        {
            return $"Видео \"{_name}\" длительностью {_duration} качеством {_quality}";
        }
    }
    
    public class Program
    {
        static void PrintVideos(in VideoFile[] videos)
        {
            for (int i = 0; i < videos.Length; i++)
            {
                Console.WriteLine(videos[i].GetInfo());
            }
        }
        
        static void Main()
        {
            do
            {
                Random rnd = new Random();

                VideoFile[] videoFiles = new VideoFile[rnd.Next(5, 15)];

                for (int i = 0; i < videoFiles.Length; i++)
                {
                    videoFiles[i] = new VideoFile($"Видео {i}", rnd.Next(60, 360), rnd.Next(100, 1000));
                }
                
                PrintVideos(videoFiles);

                int a;
                do
                {
                    Console.WriteLine("Введите номер файла: ");
                } while (!(int.TryParse(Console.ReadLine(), out a) && a >= 0 && a < videoFiles.Length));

                foreach (var videoFile in videoFiles)
                {
                    if (videoFiles[a].Size < videoFile.Size)
                    {
                        Console.WriteLine(videoFile.GetInfo());
                    }
                }

                Console.WriteLine("Нажмите ESC чтобы выйти...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}

