namespace SortingAlgorithms
{
    internal class Algorithms
    {
        /// <summary>
        /// SimpleSort: A basic sorting algorithm that compares each element with every other element
        /// and swaps them if they are out of order. This results in a sorted array in ascending order.
        /// Time Complexity: O(n^2) (Quadratic)
        /// </summary>
        public static int[] SimpleSort(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }

        /// <summary>
        /// ReverseSimpleSort: Similar to SimpleSort, but sorts the array in descending order.
        /// Time Complexity: O(n^2) (Quadratic)
        /// </summary>
        public static int[] ReverseSimpleSort(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }

        /// <summary>
        /// BubbleSort: Repeatedly swaps adjacent elements if they are in the wrong order.
        /// The largest elements "bubble up" to the end of the array.
        /// Time Complexity: O(n^2) (Quadratic) in the worst case, O(n) in the best case (already sorted).
        /// </summary>
        public static int[] BubbleSort(int[] nums)
        {
            int t;
            bool f;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                f = false;
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        t = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = t;
                        f = true;
                    }
                }
                if (!f)
                    break;
            }
            return nums;
        }

        /// <summary>
        /// SelectionSort: Selects the smallest element from the unsorted part of the array
        /// and swaps it with the first element of the unsorted part.
        /// Time Complexity: O(n^2) (Quadratic)
        /// </summary>
        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        /// <summary>
        /// InsertionSort: Builds the sorted array one element at a time by inserting elements
        /// into their correct position in the sorted portion of the array.
        /// Time Complexity: O(n^2) (Quadratic) in the worst case, O(n) in the best case (already sorted).
        /// </summary>
        public static int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        /// <summary>
        /// MergeSort: A divide-and-conquer algorithm that splits the array into halves,
        /// recursively sorts each half, and merges them back together.
        /// Time Complexity: O(n log n) (Logarithmic)
        /// </summary>
        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;
            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];
            for (int i = 0; i < mid; i++)
                left[i] = arr[i];
            for (int i = mid; i < arr.Length; i++)
                right[i - mid] = arr[i];
            return Merge(MergeSort(left), MergeSort(right));
        }



        // Uncomment the following method if you want to use the recursive MergeSort implementation
        // This method using built-in Array.Copy for better performance
        /*public static int[] MergeSort(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return arr?.ToArray() ?? Array.Empty<int>();

            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];
            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, arr.Length - mid);

            return Merge(MergeSort(left), MergeSort(right));
        }
        */



        /// <summary>
        /// BucketSort: Distributes elements into buckets based on their value,
        /// sorts each bucket, and combines them back into a single array.
        /// Time Complexity: O(n + k) (Linear), where k is the number of buckets.
        /// </summary>
        public static int[] BucketSort(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                    maxValue = arr[i];
            }
            int[] bucket = new int[maxValue + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                bucket[arr[i]]++;
            }
            int index = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                while (bucket[i] > 0)
                {
                    arr[index++] = i;
                    bucket[i]--;
                }
            }
            return arr;
        }

        /// <summary>
        /// CountSort: Counts the occurrences of each element and reconstructs the sorted array
        /// based on the counts.
        /// Time Complexity: O(n + k) (Linear), where k is the range of input values.
        /// </summary>
        public static int[] CountSort(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                    maxValue = arr[i];
            }
            int[] count = new int[maxValue + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }
            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    arr[index++] = i;
                    count[i]--;
                }
            }
            return arr;
        }

        /// <summary>
        /// Merge: Helper method for MergeSort that merges two sorted arrays into one.
        /// </summary>
        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }
            while (i < left.Length)
            {
                result[k++] = left[i++];
            }
            while (j < right.Length)
            {
                result[k++] = right[j++];
            }
            return result;
        }
    }
}
