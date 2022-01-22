public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var i = 0;
        foreach(var num in nums)
        {
            if(num != val)
            {
                nums[i] = num;
                i++;
            }
        }
        return i;
    }
}
//Runtime: 171 ms, faster than 35.88%
//Memory Usage: 38.8 MB, less than 88.75%