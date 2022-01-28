public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var dict = new Dictionary<int, int>();
        
        for(var i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict.Add(nums[i],1);
        }
        
        var arr = new int[nums.Length];
        for(var i = 0; i < arr.Length; i++)
        {
            var count = 0;
            foreach(var pair in dict)
            {
                if(pair.Key < nums[i])
                    count += pair.Value;
            }
            arr[i] = count;
        }
        
        return arr;
    }
}
//Runtime: 202 ms, faster than 36.12%
//Memory Usage: 42.5 MB, less than 12.54%

public class Solution1 {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var dict = new Dictionary<int, int>();
        var copy = (int[])nums.Clone();
        Array.Sort(copy);
        for(var i = 0; i < copy.Length; i++)
        {
            if(!dict.ContainsKey(copy[i]))
                dict.Add(copy[i],i);
        }
        
        for(var i = 0; i < nums.Length; i++)
            copy[i] = dict[nums[i]];
        
        return copy;
    }
}
//Runtime: 140 ms, faster than 63.58%
//Memory Usage: 44.8 MB, less than 5.37%