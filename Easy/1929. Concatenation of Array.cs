public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var array = new int[nums.Length*2];
        for(var i = 0; i < nums.Length; i++)
        {
            array[i] = array[i+nums.Length] = nums[i];
        }
        return array;
    }
}
//Runtime: 243 ms, faster than 10.40%
//Memory Usage: 43.8 MB, less than 32.46%