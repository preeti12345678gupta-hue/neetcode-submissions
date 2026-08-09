public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string, int> map = new Dictionary<string, int>();
        foreach(string ch in arr){
            if(map.ContainsKey(ch)){
                map[ch]++;
            }else{
                map[ch] = 1;
            }
        }

        foreach(string s in arr){
            if(map[s] == 1){
                k--;
                if(k == 0){
                    return s;
                }
            }
        }
        return "";
    }
}