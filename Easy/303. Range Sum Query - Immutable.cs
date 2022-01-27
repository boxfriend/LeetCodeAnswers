public class NumArray {
    private readonly int[] nums;
    public NumArray(int[] nums) {
        this.nums = nums;
    }
    
    public int SumRange(int left, int right) {
        var sum = 0;
        for(var i = left; i <= right; i++)
        {
            sum += nums[i];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
 
 //Runtime: 176 ms, faster than 68.22%
 //Memory Usage: 55.8 MB, less than 30.23%
 
 public class NumArray1 {
    private readonly int[] num;
    
    public NumArray(int[] nums) {
        num = new int[nums.Length+1];
        
        for(var i = 1; i < num.Length; i++)
        {
            num[i] = nums[i-1] + num[i-1];
        }
    }
    
    public int SumRange(int left, int right) => num[right+1]-num[left];
    
}
//Runtime: 144 ms, faster than 83.72%
//Memory Usage: 55.6 MB, less than 44.57%