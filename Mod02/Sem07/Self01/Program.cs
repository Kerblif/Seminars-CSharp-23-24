namespace Program
{
    public static class Program
    {
        static Random rnd = new Random();
        
        static int CountAlive(in Mage[] mages)
        {
            int res = 0;

            foreach (var mage in mages)
            {
                res += mage.Health <= 0 ? 0 : 1;
            }

            return res;
        }
        
        static void Battle(in Mage[] mages)
        {
            int t = 0;
            
            while (CountAlive(mages) > 1)
            {
                int target;

                do
                {
                    target = (int)(rnd.NextInt64() % mages.Length);
                } while (!(target == (t % mages.Length)) && mages[target].Health <= 0);

                if (mages[t % mages.Length].Health > 0)
                {
                    mages[t % mages.Length].Atack(mages[target]);
                }

                t++;
            }
        }        
        
        static void Main()
        {
            Mage[][] mages = new Mage[][] { };

            Array.Resize(ref mages, 2);
            mages[0] = new Mage[]{};
            mages[1] = new Mage[]{};

            Array.Resize(ref mages[0], 3);
            Array.Resize(ref mages[1], 3);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    mages[i][j] = (rnd.NextInt64() % 3) switch
                    {
                        0 => new Mage((int)(rnd.NextInt64() % 99 + 1), (int)(rnd.NextInt64() % 9 + 1)),
                        1 => new IceMage((int)(rnd.NextInt64() % 99 + 1), (int)(rnd.NextInt64() % 9 + 1)),
                        2 => new FireMage((int)(rnd.NextInt64() % 99 + 1), (int)(rnd.NextInt64() % 9 + 1))
                    };
                }
            }
            
            Battle(mages[0]);
            Battle(mages[1]);

            for (int i = 0; i < mages.Length; i++)
            {
                if (mages[0][i].Health > 0)
                {
                    Console.WriteLine(mages[0][i]);
                }
                
                if (mages[1][i].Health > 0)
                {
                    Console.WriteLine(mages[1][i]);
                }
            }
        }
    }
}