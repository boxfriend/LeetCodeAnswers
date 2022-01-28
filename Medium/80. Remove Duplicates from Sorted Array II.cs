public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) return nums.Length; 
        var pointer = 1;
        var count = 0;
        for(var i = 1; i < nums.Length; i++)
        {
            count = nums[i] == nums[i-1] ? count+1 : 0;
            nums[pointer++] = nums[i];
            if(count > 1) pointer--;
        }
        
        return pointer;
    }
}
//Runtime: 214 ms, faster than 19.16%
//Memory Usage: 42.9 MB, less than 7.28%