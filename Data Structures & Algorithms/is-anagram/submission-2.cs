public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;

        int[] count = new int[26];
        foreach(char ch in s){
            if(count[ch - 'a'] > 0)
                count[ch - 'a']++;
            else
                count[ch - 'a'] = 1;
        }

        foreach(char ch in t){
            if(count[ch - 'a'] > 0)
                count[ch - 'a']--;
            else
                count[ch - 'a'] = 1;
        }

        foreach(int num in count){
            if(num != 0)
                return false;
            
        }

        return true;
    }
}
