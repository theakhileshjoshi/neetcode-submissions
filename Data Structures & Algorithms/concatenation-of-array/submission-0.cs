public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] res = new int[nums.Length * 2];
        int resItr = 0;
        int numItr = 0;
        while(resItr < res.Length){
            if(numItr >= nums.Length)
                numItr = 0;
            
            res[resItr] = nums[numItr];

            resItr++;
            numItr++;
        }

        return res;
    }
}