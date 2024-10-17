
using CountingSort;

// Input array
List<int> inputArray = new List<int> { 4, 3, 12, 1, 5, 5, 3, 9 };
// Output array
Console.WriteLine("Array Ordenado: ");
List<int> outputArray = CountingSort.CountingSort.CountSort(inputArray);
        for (int i = 0; i < inputArray.Count; i++)
            Console.Write(outputArray[i] + " ");
