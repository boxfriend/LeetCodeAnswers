public class Solution {
    public string ToLowerCase(string s) {
        var length = s.Length;
        var chars = new char[length];
        for(var i = 0; i < length; i++)
            chars[i] = s[i];
        
        var toLower = 'a' - 'A';
        for(var i = 0; i <= length/2; i++)
        {
            if(char.IsUpper(chars[i]))
                chars[i] = (char)(chars[i]+toLower);
                
            if(char.IsUpper(chars[length - i - 1]))
                chars[length - i - 1] = (char)(chars[length - i - 1]+toLower);
        }
        
        return string.Join("", chars);
    }
}
//Runtime: 185 ms, faster than 5.00%
//Memory Usage: 35 MB, less than 96.25%