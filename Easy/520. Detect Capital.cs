public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word.Length <= 1) return true;
        
        var firstCapital = char.IsUpper(word, 0);
        var secondCapital = char.IsUpper(word, 1);
        if(!firstCapital && secondCapital) return false;
        
        for(var i = 2; i < word.Length; i++)
        {
            if(char.IsUpper(word,i) != secondCapital)
                return false;
        }
        
        return true;
    }
}
//Runtime: 76 ms, faster than 82.98%
//Memory Usage: 38.3 MB, less than 69.15%