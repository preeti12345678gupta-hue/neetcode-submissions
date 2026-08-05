public class Solution {
    public int MaxDifference(string s) {
        int[] freq = new int[26];
        foreach(char ch in s){
            freq[ch - 'a']++;
        }

        int maxOdd = 0;
        int minEven = int.MaxValue;

        foreach(int f in freq){
            if(f == 0) continue;
            if(f % 2 == 1){
                maxOdd = Math.Max(maxOdd, f);
            }else{
                minEven = Math.Min(minEven, f);
            }
        }

        return maxOdd - minEven;
    }
}