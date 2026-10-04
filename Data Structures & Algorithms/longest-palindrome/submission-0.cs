public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char , int> map = new Dictionary<char,int>();
        foreach(char ch in s){
            if(!map.ContainsKey(ch)){
                map[ch] = 0;
            }
            map[ch]++;
        }
        int maxlen = 0;
        bool hash = false;

        foreach(var item in map){
            int count = item.Value;
            if(count % 2 == 0){
                maxlen += count;
            }else{
                maxlen += count - 1;
                hash = true;
            }

           



        }
         if(hash){
                maxlen++;
            }

        return maxlen;
    }
}