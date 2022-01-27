public class Solution {
    public void MoveZeroes(int[] nums) {
        var pointer = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            while(pointer < nums.Length && nums[pointer] == 0)
                pointer++;
            
            if(pointer >= nums.Length)
                nums[i] = 0;
            else
                nums[i] = nums[pointer++];
        }
    }
}
//Runtime: 208 ms, faster than 42.45%
//Memory Usage: 44.9 MB, less than 62.14%