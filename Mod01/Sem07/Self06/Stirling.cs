
namespace Self06
{
    static class Stirling
    {
        #region Private Inner Methods

        // Числа Стирлинга первого порядка со знаком.
        private static long Stirling1Sign(int n, int k)
        {
            if (n == k) return 1;
            if (k == 0) return 0;
            return Stirling1Sign(n - 1, k - 1) - (n - 1) * Stirling1Sign(n - 1, k);
        }

        // Числа Стирлинга первого порядка без знака.
        private static long Stirling1USign(int n, int k)
        {
            if (n == k) return 1;
            if (k == 0) return 0;
            return Stirling1USign(n - 1, k - 1) + (n - 1) * Stirling1USign(n - 1, k);
        }

        // Числа Стирлинга второго порядка.
        private static long Stirling2(int n, int k)
        {
            if (n == k) return 1;
            if (k == 0) return 0;
            return Stirling2(n - 1, k - 1) + k * Stirling2(n - 1, k);
        }

        #endregion


        // Числа Стирлинга первого порядка со знаком.
        public static bool IsStirling1Sign(int n, int k, out long value)
        {
            value = 0;
            if (k > n) return false;

            value = Stirling1Sign(n, k);
            return true;
        }

        // Числа Стирлинга первого порядка без знака.
        public static bool IsStirling1USign(int n, int k, out long value)
        {
            value = 0;
            if (k > n) return false;

            value = Stirling1USign(n, k);
            return true;
        }

        // Числа Стирлинга второго порядка.
        public static bool IsStirling2(int n, int k, out long value)
        {
            value = 0;
            if (k > n) return false;

            value = Stirling2(n, k);
            return true;
        }
    }
}
