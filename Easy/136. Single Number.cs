public class Solution {
    public int SingleNumber(int[] nums) {
        var dict = new Dictionary<int,int>();
        for(var i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict.Add(nums[i],0);
        }
        foreach(var pair in dict)
            if(pair.Value == 0)
                return pair.Key;
        
        return 0;
    }
}
//Runtime: 173 ms, faster than 28.08%
//Memory Usage: 39.1 MB, less than 59.77%