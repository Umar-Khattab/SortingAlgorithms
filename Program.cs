using SortingAlgorithms;

int[] Arr = new int[] { 147834, 6, 47, 895, 757, 3564, 857 };
int[] sorted = Algorithms.ReverseSimpleSort(Arr);
for(int i = 0; i < sorted.Length; i++)
{
    Console.Write($"{sorted[i]}  ");
}
Console.WriteLine();