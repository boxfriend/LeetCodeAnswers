public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var tempArr = new int[m];
        for(var i = 0; i < tempArr.Length; i++)
            tempArr[i] = nums1[i];
        
        var n1 = 0;
        var n2 = 0;
        for(var i = 0; i < nums1.Length; i++)
        {
            if(n1 > tempArr.Length-1)
            {
                nums1[i] = nums2[n2++];
                continue;
            }
            if(n2 > nums2.Length-1)
            {
                nums1[i] = tempArr[n1++];
                continue;
            }
            
            if(tempArr[n1] > nums2[n2])
                nums1[i] = nums2[n2++];
            else
                nums1[i] = tempArr[n1++];
        }
    }
}
//Runtime: 202 ms, faster than 23.21%
//Memory Usage: 41.3 MB, less than 8.31%