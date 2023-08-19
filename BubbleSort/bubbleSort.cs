public static void bubbleSort(int[] array)
{
    int length = array.Length - 1;

    for (int k = 0; k < array.Length - 1 ; k++)
    {
        for (int i = 0; i < length; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }                    
        }
        length--;
    }
}
