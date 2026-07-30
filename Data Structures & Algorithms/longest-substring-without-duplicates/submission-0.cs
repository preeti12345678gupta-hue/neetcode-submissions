public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> map = new HashSet<char>();

        int left = 0;
        int longest = 0;
        for(int right = 0; right < s.Length; right++){
            while(map.Contains(s[right])){
                map.Remove(s[left]);
                left++;


            }
            map.Add(s[right]);

            longest = Math.Max(longest, right - left + 1);
        }

        return longest;

    }
}
