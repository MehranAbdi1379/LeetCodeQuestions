// See https://aka.ms/new-console-template for more information

Console.WriteLine(RemoveElement(new int[] { 1, 5, 6, 8, 4, 4, 3, 6, 8, 9, 4 }, 4));

int RemoveElement(int[] nums, int val)
{
    //for (int i = 0; i < nums.Length; i++)
    //{
    //    if (nums[i] == val) nums[i] = int.MaxValue;
    //}

    //int lastOne = 0;
    //for (int i = nums.Length - 1; i >= 0; i++)
    //{
    //    if (nums[i] != int.MaxValue)
    //    {
    //        lastOne = nums[i];
    //        break;
    //    }
    //}
    //for (int i = 0; i < UPPER; i++)
    //{

    //}
    var counter = nums.Length;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == val)
        {
            counter--;
            for (int j = i; j < nums.Length - 1; j++)
            {
                nums[j] = nums[j + 1];
            }
            nums[counter] = int.MaxValue;
            i--;
        }
    }

    return counter;
}