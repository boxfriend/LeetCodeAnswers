public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length < 1)
            return true;
        
        var i = 0;
        foreach(var ch in t)
        {
            if(ch == s[i])
                i++;
            
            if(i >= s.Length)
                return true;
        }
        
        return false;
    }
}
//Runtime: 87 ms, faster than 73.61%
//Memory Usage: 36.6 MB, less than 46.73%