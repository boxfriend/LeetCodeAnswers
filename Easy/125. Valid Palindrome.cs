public class Solution {
    public bool IsPalindrome(string s) {
       
        if(s.Length < 2) return true;
        
        
        s = s.ToLower();
        var list = new List<char>();
        foreach(var ch in s.ToCharArray())
        {
            if(char.IsLetterOrDigit(ch))
                list.Add(ch);
        }
           
        var first = 0;
        var last = list.Count-1;
        while(first < last)
        {
            if(list[first++] != list[last--])
                return false;
        }
        return true;
    }
}
//Runtime: 131 ms, faster than 33.65%
//Memory Usage: 38.8 MB, less than 67.72%