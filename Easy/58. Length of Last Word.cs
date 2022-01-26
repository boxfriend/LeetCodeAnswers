public class Solution {
    public int LengthOfLastWord(string s) {
        var arr = s.Split(" ");
        var i = arr.Length-1;
        while(string.IsNullOrWhiteSpace(arr[i]))
            i--;
        
        return arr[i].Length;
    }
}
//Runtime: 107 ms, faster than 26.40%
//Memory Usage: 34.6 MB, less than 93.12%

public class Solution1 {
    public int LengthOfLastWord(string s) {
        var end = s.Length-1;
        while(s[end] == ' ')
            end--;
        
        var count = 0;
        while(end >= 0 && s[end] != ' ')
        {
            count++;
            end--;
        }
        return count;
    }
}
//Runtime: 68 ms, faster than 81.86%
//Memory Usage: 36 MB, less than 43.00%