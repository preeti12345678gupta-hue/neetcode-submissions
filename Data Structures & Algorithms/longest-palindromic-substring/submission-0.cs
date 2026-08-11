public class Solution {
    public string LongestPalindrome(string s) {
        string res = "";
        for(int i = 0; i < s.Length; i++){
            string even = Expand(s, i , i);
            string odd = Expand(s, i , i + 1);

            if(odd.Length > res.Length){
                res = odd;
            }
            if(even.Length > res.Length){
                res = even;
            }
        }
        return res;

    }

    private string Expand(string s, int left, int right){
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left--;
            right++;
        }
        return s.Substring(left + 1, right - left - 1);
    }
}
