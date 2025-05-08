int[] nums = {4,1,2,1,2};
Console.WriteLine(UniqueElement(nums));
int UniqueElement(int[] nums)
{
    Dictionary<int, int> freq = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (freq.ContainsKey(nums[i]))
        {
            freq[nums[i]]++;
        }
        else
        {
            freq[nums[i]] = 1;
        }
    }
    foreach (var pair in freq)
    {
        if (pair.Value == 1)
        {
            return pair.Key;
        }
    }
    return -1;
}