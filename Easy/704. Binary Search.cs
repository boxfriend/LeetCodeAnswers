public class Solution {
    public int Search(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length);
    }
    
    public int BinarySearch(int[] nums, int target, int l, int r)
    {
        var index = l + (r-l)/2;
        
        if(index >= nums.Length || index < 0) return -1;
        
        if(nums[index] == target)
            return index;
        
        if(r <= l)
            return -1;
        
        if(nums[index] > target)
            return BinarySearch(nums, target, l, index-1);


        return BinarySearch(nums, target, index+1, r);
    }
}
//Runtime: 209 ms, faster than 20.35%
//Memory Usage: 40.6 MB, less than 68.28%