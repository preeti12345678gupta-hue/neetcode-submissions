public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] a = new int[26];
        int[] b = new int[26];

        foreach(char ch in s1){
            a[ch - 'a']++;
        }

        int left = 0;
        for(int right = 0; right < s2.Length; right++){
            b[s2[right] - 'a']++;

            if(right - left + 1 > s1.Length){
                b[s2[left] - 'a']--;
                left++;
            }
            if(a.SequenceEqual(b)){
                return true;
            }
        }
        return false;
    }
}
