namespace Binary_Search
{
    public class Program
    {
        static int BinarySearch(int[] arr , int low, int high, int key)
        {
            if(high < low)
                return -1;
            int mid = low + ((high - low) / 2);
            if(arr[mid] == key)
                return mid;
            if(arr[mid] > key)
                return BinarySearch(arr,low,mid-1,key);
            else
                return BinarySearch(arr,mid+1,high,key);

        }
        static void Main(string[] args)
        {          
            // for inputs array
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            string[] inputs = Console.ReadLine().Split(' ');

            for (int i = 0; i < inputs.Length; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            // for search array
            int x = int.Parse(Console.ReadLine());
            int[] searchArr = new int[x];

            string[] inputs2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < inputs2.Length; i++)
            {
                searchArr[i] = int.Parse(inputs2[i]);
            }

            int[] results = new int[x];

            for (int i = 0; i < searchArr.Length; i++)
            {
                results[i] = BinarySearch(arr, 0, arr.Length - 1, searchArr[i]);
            }
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}