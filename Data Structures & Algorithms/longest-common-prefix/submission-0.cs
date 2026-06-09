public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length  == 0)
            return "";

        for(int i = 0;i < strs[0].Length;i++){
            char curChar = strs[0][i];

            for(int j = 0; j < strs.Length;j++){
                if(strs[j].Length <= i || strs[j][i] != curChar){
                    return strs[0].Substring(0,i);
                }
            }
        }

        return strs[0];
    }
}