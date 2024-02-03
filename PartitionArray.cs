namespace MaxSumAfterPartitioning
{
    public class PartitionArray : IMaxSumAfterPartitioning
    {
        public int? Maxsum(int[] arr, int partitionLenght)
        {
            int arrayLenght = arr.Length;
            int[] dp = new int[arrayLenght + 1];

            for (int i = 1; i <= arrayLenght; i++)
            {
                int maxVal = 0;
                for (int j = 1; j <= partitionLenght && i - j >= 0; j++)
                {
                    maxVal = Math.Max(maxVal, arr[i - j]);
                    dp[i] = Math.Max(dp[i], dp[i - j] + maxVal * j);
                }
            }
            int maxSumAfterPartion = dp[arrayLenght];
            return maxSumAfterPartion ;
            
        }
    }
}
