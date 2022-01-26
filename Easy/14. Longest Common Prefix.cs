public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var str = "";
        
        for(var i = 0; i < strs[0].Length; i++)
        {
            var ch = strs[0][i];
            foreach(var s in strs)
            {
                if(i > s.Length-1 || s[i] != ch) 
                    return str;
            }
            
            str += ch;
        }
        
        return str;
    }
}
//Runtime: 162 ms, faster than 24.37%
//Memory Usage: 37.4 MB, less than 85.89%