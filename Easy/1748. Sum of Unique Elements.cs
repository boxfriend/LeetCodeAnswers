public class Solution {
    public int SumOfUnique(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach(var i in nums)
        {
            if(dict.ContainsKey(i))
                dict[i]++;
            else
                dict.Add(i,0);
        }
        
        var sum = 0;
        foreach(var pair in dict)
        {
            if(pair.Value == 0)
                sum += pair.Key;
        }
        
        return sum;
    }
}
//Runtime: 80 ms, faster than 92.75%
//Memory Usage: 38.4 MB, less than 5.07%