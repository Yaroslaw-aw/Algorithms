public static void quickSort(int[] array)
{
    quickSort(array, 0, array.Length - 1);
}

static void quickSort(int[] array, int leftBorder, int rightBorder)
{
    int leftMarker = leftBorder;
    int rightMarker = rightBorder;
    int pivot = array[(leftMarker + rightMarker) / 2];

    while (leftMarker <= rightMarker)
    {
        while (array[leftMarker] < pivot)
        {
            leftMarker++;
        }
        while (array[rightMarker] > pivot)
        {
            rightMarker--;
        }

        if (leftMarker <= rightMarker)
        {
            if (leftMarker < rightMarker)
            {
                int temp = array[leftMarker];
                array[leftMarker] = array[rightMarker];
                array[rightMarker] = temp;
            }
            leftMarker++;
            rightMarker--;
        }
    }

    if (leftMarker < rightBorder)
        quickSort(array, leftMarker, rightBorder);

    if (leftBorder < rightMarker)
        quickSort(array, leftBorder, rightMarker);
}
