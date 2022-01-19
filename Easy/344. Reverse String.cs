public class Solution {
    public void ReverseString(char[] s) {
        if(s.Length <= 1) return;
        
        var lastIndex = s.Length - 1;
        for(var i = 0; i < s.Length / 2; i++)
        {
            var temp = s[i];
            s[i] = s[lastIndex - i];
            s[lastIndex - i] = temp;
        }
    }
}
//Runtime: 266 ms, faster than 47.72%
//Memory Usage: 46.1 MB, less than 64.22%