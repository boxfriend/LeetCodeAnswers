public class Solution {
    public double Average(int[] salary) {
        var min = salary[0];
        var max = salary[0];
        var total = 0;
        foreach(var s in salary)
        {
            total += s;
            min = s < min ? s : min;
            max = s > max ? s : max;
        }
        total -= min + max;
        
        return (double)total / (salary.Length-2);
    }
}
//Runtime: 132 ms, faster than 25.04%
//Memory Usage: 36.7 MB, less than 79.24%