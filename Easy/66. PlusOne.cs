public class Solution {
    public int[] PlusOne(int[] digits) {
        for(var i = digits.Length-1; i >= 0; i--)
        {
            digits[i] += 1;
            if(digits[i] == 10)
            {
                digits[i] = 0;
                if(i == 0)
                {
                    digits = InsertAtBeginning(digits);
                }
            }
            else
                break;
        }
        return digits;
    }
    
    public int[] InsertAtBeginning(int[] array)
    {
        var newArray = new int[array.Length+1];
        newArray[0] = 1;
        for(var i = 0; i < array.Length; i++)
        {
            newArray[i+1] = array[i];
        }
        return newArray;
    }
}
//Runtime: 128 ms, faster than 54.44%
//Memory Usage: 40.7 MB, less than 24.54%
