public class Solution {
    public int ScoreOfString(string s) {
        int sumscore = 0;
        char[] arr = s.ToCharArray();
        for(int i = 0; i < arr.Length - 1; i++){
            sumscore += Math.Abs(arr[i] - arr[i + 1]);
        }
        return sumscore;
    }
}