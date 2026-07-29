public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> map = new HashSet<int>(nums);
int longest = 0;
        foreach(int num in nums){
            if(!map.Contains(num - 1)){
                int curr = num;
                int length  = 1;

                while(map.Contains(curr + 1)){
                    curr++;
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
