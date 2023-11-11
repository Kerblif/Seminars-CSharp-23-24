namespace Self01
{
    public class IntegerList
    {
        private int[] _integerList;
        private int _curPos;

        public IntegerList(int n)
        {
            if (n < 1)
            {
                throw new Exception("Передан неправильный аргумент при инициализации массива!");
            }

        _integerList = new int[n];
            _curPos = 0;

            for (int i = 0; i < n; i++)
            {
                _integerList[i] = 0;
            }
        }

        public void Randomize()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < _integerList.Length; i++)
            {
                _integerList[i] = rnd.Next();
            }

            _curPos = _integerList.Length;
        }

        public void Print()
        {
            for (int i = 0; i < _curPos; i++)
            {
                Console.WriteLine($"{i}) {_integerList[i]}");
            }
        }

        public void IncreaseSize()
        {
            Array.Resize(ref _integerList, _integerList.Length * 2);
        }

        public void AddElement(int newVal)
        {
            if (_curPos >= _integerList.Length)
            {
                IncreaseSize();
            }

            _integerList[_curPos++] = newVal;
        }

        public void RemoveFirst(int val)
        {
            int i = 0;
            for (; i < _curPos; i++)
            {
                if (_integerList[i] == val)
                {
                    break;
                }
            }

            if (i != _curPos)
            {
                for (; i < _curPos - 1; i++)
                {
                    _integerList[i] = _integerList[i + 1];
                }

                _curPos--;
            }
        }

        public void RemoveAll(int val)
        {
            int i = 0;
            
            for (; i < _curPos; i++)
            {
                if (_integerList[i] == val)
                {
                    for (int mi = i; mi < _curPos - 1; mi++)
                    {
                        _integerList[mi] = _integerList[mi + 1];
                    }

                    i--;
                    _curPos--;
                }
            }
        }
    }
    
    public class Program
    {
        static void Main()
        {
            IntegerList arr = new IntegerList(10);
            arr.AddElement(5);
            arr.AddElement(5);
            arr.AddElement(5);
            arr.AddElement(4);
            arr.AddElement(4);
            arr.AddElement(4);
            arr.AddElement(4);
            arr.Print();
            
            arr.RemoveFirst(5);
            arr.Print();
            
            arr.RemoveAll(4);
            arr.Print();
        }
    }
}

