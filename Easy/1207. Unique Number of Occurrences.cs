public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int, int>();
        foreach(var num in arr)
        {
            if(!dict.TryAdd(num,0))
                dict[num]++;
        }
        
        var hash = new HashSet<int>();
        foreach(var pair in dict)
        {
            if(!hash.Add(pair.Value))
                return false;
        }
        return true;
    }
}
//Runtime: 149 ms, faster than 41.18%
//Memory Usage: 38.5 MB, less than 50.00%