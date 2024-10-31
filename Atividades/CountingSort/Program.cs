
using CountingSort;

// Input array
List<int> inputArray = new List<int> { 4, 3, 12, 1, 5, 5, 3, 9 };
Console.WriteLine();
Console.WriteLine("Array Desordenado: ");
Console.Write("[ ");
for (int i = 0; i < inputArray.Count; i++)
    Console.Write(inputArray[i] + " ");
Console.Write("]");
Console.WriteLine();

// Output array
Console.WriteLine("");
Console.WriteLine("Array Ordenado: ");
Console.Write("[ ");
List<int> outputArray = CountingSort.CountingSort.CountSort(inputArray);
for (int i = 0; i < inputArray.Count; i++)
    Console.Write(outputArray[i] + " ");
Console.Write("]");