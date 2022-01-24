public class Solution {
    public string CapitalizeTitle(string title) {
        var words = title.ToLower().Split(' ');
        for(var i = 0; i < words.Length; i++)
        {
            if(words[i].Length <= 2) continue;
            var chars = words[i].ToCharArray();
            chars[0] = char.ToUpper(chars[0]);
            words[i] = string.Join("", chars);
        }
        
        return string.Join(' ', words);
    }
}
//Runtime: 181 ms, faster than 5.47%
//Memory Usage: 36.8 MB, less than 79.60%