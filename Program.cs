namespace Heapify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            randomizeArray(array, 10);
            print(array);
            heapSort(array);
            print(array);

            void randomizeArray(int[] array, int max)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(max);
                }
            }

            void print(int[] array)
            {
                foreach (int i in array)
                {
                    Console.Write(String.Format("{0, 2}", i));
                }
                Console.WriteLine();
            }

            void heapSort(int[] array)
            {
                int n = array.Length;

                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    heapify(array, n, i);
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    int temp = array[0];
                    array[0] = array[i];
                    array[i] = temp;

                    heapify(array, i, 0);
                }
            }

            void heapify(int[] array, int n, int i)
            {
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < n && array[left] > array[largest])                
                    largest = left;
                
                if (right < n && array[right] > array[largest])                
                    largest = right;                

                if (largest != i)
                {
                    int temp = array[i];
                    array[i] = array[largest];
                    array[largest] = temp;

                    heapify(array, n, largest);
                }
            }
        }
    }
}