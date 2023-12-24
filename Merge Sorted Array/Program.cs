// See https://aka.ms/new-console-template for more information

Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    for (int i = m + n - 1; i >= 0; i--)
    {
        if (n > 0 && m > 0 && nums1[m - 1] > nums2[n - 1])
        {
            nums1[i] = nums1[m - 1];
            m--;
        }
        else if (n > 0)
        {
            nums1[i] = nums2[n - 1];
            n--;
        }
    }

    foreach (var num in nums1)
    {
        Console.WriteLine(num);
    }
}