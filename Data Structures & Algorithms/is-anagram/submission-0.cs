public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach(char ch in s){
            if(map.ContainsKey(ch)){
                map[ch]++;
            }else{
                map[ch] = 1;
            }
        }
        foreach(char ch in t){
            if(!map.ContainsKey(ch)){
                return false;
            }
            map[ch]--;

            if(map[ch] < 0){
                return false;
            }
        }

        foreach(int val in map.Values){
            if(val != 0){
                return false;
            }
        }

        return true;


    }
}
