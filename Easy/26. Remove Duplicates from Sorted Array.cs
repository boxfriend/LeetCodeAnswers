public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length < 1) return 0;
        
        var counter = 0;
        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[counter])
            {
                nums[++counter] = nums[i];
            }
        }
        
        return counter+1;
    }
}
//Runtime: 132 ms, faster than 84.80%
//Memory Usage: 43.6 MB, less than 47.05%