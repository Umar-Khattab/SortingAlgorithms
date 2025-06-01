namespace SortingAlgorithms
{
    internal class Algorithms
    {
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
        public static int[] selectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        public static int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
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
    }
}