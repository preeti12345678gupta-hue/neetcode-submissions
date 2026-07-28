public class Solution {
    public int LengthOfLastWord(string s) {
        string[] str = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        string n = str[str.Length - 1];
        int count = 0;
        for(int i = 0; i < n.Length; i++){
            count++;
        }

        return count;
    }
}