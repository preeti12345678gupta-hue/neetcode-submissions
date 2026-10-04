public class Solution {
    public char FindTheDifference(string s, string t) {
        Dictionary<char,int> maps = new Dictionary<char,int>();
         Dictionary<char,int> mapt = new Dictionary<char,int>();

         foreach(char ch in s){
            if(!maps.ContainsKey(ch)){
                maps[ch] = 0;
            }
            maps[ch]++;
         }

          foreach(char ch in t){
            if(!mapt.ContainsKey(ch)){
                mapt[ch] = 0;
            }
            mapt[ch]++;
         }

         foreach(char ch in t){
            if(!maps.ContainsKey(ch) || maps[ch] != mapt[ch]){
                return ch;
            }
         }

         return '\0';

    }
}