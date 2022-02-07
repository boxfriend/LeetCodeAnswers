public class Solution {
    public char FindTheDifference(string s, string t) {
        var dict = new Dictionary<char, int>();
        var charS = s.ToCharArray();
        foreach(var ch in charS)
        {
            if(!dict.TryAdd(ch,0))
                dict[ch]++;
        }
                
        var dict2 = new Dictionary<char, int>();
        var charT = t.ToCharArray();
        foreach(var ch in charT)
        {
            if(!dict.ContainsKey(ch))
                return ch;
            
            if(!dict2.TryAdd(ch,0))
                dict2[ch]++;
        }
        
        foreach(var pair in dict2)
        {
            if(dict[pair.Key] != pair.Value)
                return pair.Key;
        }
        
        return ' ';
    }
}
//Runtime: 88 ms, faster than 88.36%
//Memory Usage: 39.7 MB, less than 6.03%

public class Solution {
    public char FindTheDifference(string s, string t) {
        var sSum = 0;
        foreach(var ch in s)
            sSum += (int)ch;
            
        var tSum = 0;
        foreach(var ch in t)
            tSum += (int)ch;
        
        return (char)(tSum - sSum);
    }
}
//Runtime: 124 ms, faster than 46.98%
//Memory Usage: 37.2 MB, less than 67.24%