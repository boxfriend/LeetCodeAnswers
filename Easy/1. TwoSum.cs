public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new Dictionary<int, List<int>>();
        var answer = new int[2];
        for (var i = 0; i < nums.Length; i++)
        {

            if (!hash.ContainsKey(nums[i]))
            {
                var list = new List<int> { i };
                hash.Add(nums[i],list);
            } else
            {
                hash[nums[i]].Add(i);
            }

            var toCheck = target - nums[i];
            if (hash.ContainsKey(toCheck))
            {
                if (nums[i] == toCheck && hash[nums[i]].Count > 1) 
                    answer = hash[nums[i]].ToArray();
                else if (nums[i] == toCheck && hash[nums[i]].Count == 1)
                    continue;

                answer[0] = i;
                answer[1] = hash[toCheck][0];
                break;
            }
        }
        return answer;
    }
}
//Runtime: 217 ms, faster than 31.95%
//Memory Usage: 41.9 MB, less than 57.26%