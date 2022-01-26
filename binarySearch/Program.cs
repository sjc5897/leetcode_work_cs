using System;
using System.IO;

namespace binarySearch
{
    class Program
    {
        public static int Search(int[] nums, int target) {
            int left = 0;
            int right = nums.Length - 1;
        
            while(left <= right){
                int middle = left + (right - left) / 2;
                if(nums[middle] == target){
                    return middle;
                }
                else if(nums[middle] > target){
                    right = middle - 1;
                }
                else{
                    left = middle + 1;
                }
            }
        
            return -1;
        
        }
        
        static void Main(string[] args)
        {
            int[] nums = new int[] {-1,0,3,5,9,12};
            int target = 9;
            
            Console.WriteLine(Search(nums,target));
        }
    }
}