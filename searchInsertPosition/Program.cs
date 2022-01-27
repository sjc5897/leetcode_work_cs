// See https://aka.ms/new-console-template for more information

// https://leetcode.com/problems/search-insert-position/
public class SearchInsertPosition{
    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            if (nums[middle] == target)
            {
                return middle;
            }

            if (nums[middle] > target)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return right + 1;
    }

    public static void Main(String[] args)
    {
        int[] nums = new[] {1, 3, 5, 6};
        int target = 5;
        Console.Write(SearchInsert(nums,target));
    }

}