namespace _2466.Count_Ways_To_Build_Good_Strings
{
    internal class Program
    {
        private const int Mod = 1_000_000_000 + 7;

        public int CountGoodStrings(int low, int high, int zero, int one)
        {
            var dp = new int[high + 1];
            dp[0] = 1;

            var result = 0;

            for (var i = 1; i <= high; ++i)
            {
                if (i >= zero)
                {
                    dp[i] = (dp[i] + dp[i - zero]) % Mod;
                }

                if (i >= one)
                {
                    dp[i] = (dp[i] + dp[i - one]) % Mod;
                }

                if (i >= low)
                {
                    result = (result + dp[i]) % Mod;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine(program.CountGoodStrings(3, 3, 1, 1));
        }
    }
}