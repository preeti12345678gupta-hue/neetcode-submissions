public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach(char ch in s){
            if(!map.ContainsKey(ch)){
                map[ch] = 0;
            }
            map[ch]++;
        }

        for(int i = 0; i < s.Length; i++){
            if(map[s[i]] == 1){
                return i;
            }
        }

        return -1;

    }
}