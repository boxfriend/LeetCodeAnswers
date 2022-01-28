public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var hash = new HashSet<char>();
        foreach(var ch in jewels)
            hash.Add(ch);
        
        var count = 0;
        foreach(var ch in stones)
            if(hash.Contains(ch))
                count++;
        
        return count;
    }
}
//Runtime: 121 ms, faster than 14.23%
//Memory Usage: 35.7 MB, less than 55.89%