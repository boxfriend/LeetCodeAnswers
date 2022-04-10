public class Solution {
    public int CalPoints(string[] ops) {
        var list = new List<int>();
        foreach(var s in ops)
        {
            if(s == "C")
            {
                list.RemoveAt(list.Count-1);
            } else if(s == "D")
            {
                list.Add(list[^1]*2);
            } else if (s == "+")
            {
                var a = list[^1];
                var b = list[^2];
                list.Add(a+b);
            } else
            {
                list.Add(Convert.ToInt32(s));
            }
        }
        var total = 0;
        foreach(var i in list)
            total += i;
        
        return total;
    }
}
//Runtime: 76 ms, faster than 96.19%
//Memory Usage: 39.5 MB, less than 10.48%