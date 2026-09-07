public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int size = nums.Length;
        int[] res = new int[size * 2];

        if(nums.Length == 0)
            return null;

        for(int i = 0; i < res.Length; i++)
            res[i] = nums[i % size];
        
        return res;
    }
}