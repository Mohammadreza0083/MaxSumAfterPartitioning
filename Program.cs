namespace MaxSumAfterPartitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new();
            Console.WriteLine("Welcome to PartitionArray app");
            Console.WriteLine("Do you want add item to your array: press 'Y' for yes and 'N' for no ");
            string condition = Console.ReadLine();
            int item;
            while (condition == "Y" || condition == "y") {
                item = Convert.ToInt32(Console.ReadLine());
                list.Add(item);
                Console.WriteLine("Do you want add item to your array: press 'Y' for yes and 'N' for no ");
                condition = Console.ReadLine();
            }
            Console.WriteLine("Enter your Partition value :");
            int Partitionkey = Convert.ToInt32(Console.ReadLine());
            int[] arr = list.ToArray();
            PartitionArray partitionArray = new PartitionArray();
            int MaxSumAfterPartitioning = partitionArray.MaxSum(arr, Partitionkey);
            string listString = String.Join(", ", list);
            Console.WriteLine($"Max sum after partition in array : {listString} with partition value : {Partitionkey} is: {MaxSumAfterPartitioning} ");



        }
    }
}
