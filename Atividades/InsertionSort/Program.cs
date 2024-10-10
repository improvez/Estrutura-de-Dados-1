
using InsertionSort;

int[] inteiros = [0, 12, 7, 1, 2, 8];

InsertionSort.InsertionSort.Print(inteiros);

InsertionSort.InsertionSort.Sort<int>(inteiros);

InsertionSort.InsertionSort.Print(inteiros);

Console.WriteLine($"Teste Char ");

char[] chars = ['x', 'z', 'b', 'c', 'a'];

InsertionSort.InsertionSort.Print(chars);
InsertionSort.InsertionSort.Sort(chars);
InsertionSort.InsertionSort.Print(chars);