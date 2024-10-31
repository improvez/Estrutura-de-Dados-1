using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingSort {
    public class CountingSort {
        public static List<int> CountSort(List<int> inputArray) {
        int n = inputArray.Count;
        int m = 0;

        for (int i = 0; i < n; i++) m = Math.Max(m, inputArray[i]);
        List<int> countArray = new List<int>(new int[m + 1]);

        for (int i = 0; i < n; i++) countArray[inputArray[i]]++;

        for (int i = 1; i <= m; i++) countArray[i] += countArray[i - 1];
        List<int> outputArray = new List<int>(new int[n]);

        for (int i = n - 1; i >= 0; i--) {
            outputArray[countArray[inputArray[i]] - 1] = inputArray[i];
            countArray[inputArray[i]]--;
        }

        return outputArray;
        }
    }
}