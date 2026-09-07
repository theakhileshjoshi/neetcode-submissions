public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] nums = new int[26];
        
        foreach(char ch in s){
            nums[ch - 'a']++;
        }
        foreach(char ch in t){
            nums[ch - 'a']--;
        }
        foreach(int num in nums)
            if(num != 0)
                return false;
        
        return true;
    }
}