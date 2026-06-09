public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];

        int[] prefixArr = new int[nums.Length];
        int[] suffixArr = new int[nums.Length];
        int currIndex = 1;

        prefixArr[0] = 1;
        suffixArr[nums.Length - 1] = 1;
        

        while(currIndex < nums.Length){
            prefixArr[currIndex] = prefixArr[currIndex - 1] * nums[currIndex - 1];
            currIndex++;
        }

        currIndex = nums.Length - 2;

        while(currIndex >= 0){
            suffixArr[currIndex] = suffixArr[currIndex + 1] * nums[currIndex + 1];
            currIndex--;
        }

        for(int i = 0; i< nums.Length;i++){
            result[i] = prefixArr[i] * suffixArr[i]; 
        }

        return result;
    }
}





