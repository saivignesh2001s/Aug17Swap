namespace aug17swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter i and j");
            i = Convert.ToInt32(Console.ReadLine());
            j= Convert.ToInt32(Console.ReadLine());
            swap(i, j);
            Console.WriteLine("Actual numbers: {0} and {1}", i, j);
            gswap(ref i, ref j);
            Console.WriteLine("Actual numbers: {0} and {1}", i, j);
            Console.ReadLine();
        }
        static void swap(int i,int j)
        {
            int k;
            k = i;
            i = j;
            j = k;
            Console.WriteLine("Swapped numbers: {0} and {1}", i, j);
        }
        static void gswap(ref int i,ref int j)
        {
            int k;
            k = i;
            i = j;
            j = k;
            Console.WriteLine("Swapped numbers: {0} and {1}", i, j);


        }
    }
}