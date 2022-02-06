public class Solution {
    private Dictionary<char, Point> dirs = new Dictionary<char, Point>(){
        {'N',new Point(0,1)},
        {'S',new Point(0,-1)},
        {'E',new Point(1,0)},
        {'W',new Point(-1,0)}
    };
    public bool IsPathCrossing(string path) {
        var hash = new HashSet<Point>();
        var point = new Point(0,0);
        hash.Add(point);
        foreach(var ch in path)
        {
            point += dirs[ch];
            if(!hash.Add(point))
                return true;
        }
        return false;
    }
    
    private struct Point
    {
        public int X;
        public int Y;
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);
    }
}
//Runtime: 99 ms, faster than 50.00%
//Memory Usage: 37.1 MB, less than 52.78%