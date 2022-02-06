public class Solution {
    public int CountSegments(string s) {
        if(string.IsNullOrWhiteSpace(s)) return 0;
        if(s.Length == 1) return 1;
        var count = 0;
        for(var i = 1; i < s.Length; i++)
        {
            if((s[i] == ' ' && s[i-1] != ' ') || (i == s.Length-1 && s[i] != ' '))
                count++;
        
        }
        return count;
    }
}
//Runtime: 77 ms, faster than 50.00%
//Memory Usage: 34.2 MB, less than 52.08%