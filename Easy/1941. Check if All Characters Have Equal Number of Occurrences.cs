public class Solution {
    public bool AreOccurrencesEqual(string s) {
        if(s.Length <= 2) return true;
        
        var dict = new Dictionary<char, int>();
        foreach(var ch in s)
        {
            if(dict.ContainsKey(ch))
                dict[ch]++;
            else
                dict.Add(ch,0);
        }
        
        foreach(var pair in dict)
        {
            if(pair.Value != dict[s[0]])
                return false;
        }
        
        return true;
    }
}
//Runtime: 72 ms, faster than 97.56%
//Memory Usage: 38.4 MB, less than 6.10%