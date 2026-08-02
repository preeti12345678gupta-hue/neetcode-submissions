public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int left = 0;
        int max = 0;
        int res = 0;
        for(int right = 0; right < s.Length; right++){
            freq[s[right] - 'A']++;

            max = Math.Max(max, freq[s[right] - 'A']);

            while((right - left + 1) - max > k){
                freq[s[left] - 'A']--;
                left++;
            }
            res = Math.Max(res, right - left + 1);
        }

        return res;
    }
}
