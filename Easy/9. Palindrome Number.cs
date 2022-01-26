public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        var str = x.ToString();
        for(var i = 0; i < str.Length/2; i++)
        {
            if(str[i] != str[str.Length - 1 - i])
                return false;
        }
        return true;
    }
}
//Runtime: 66 ms, faster than 46.58%
//Memory Usage: 28.4 MB, less than 75.22%