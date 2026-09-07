public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int miss = 1;
        Array.Sort(nums);

        foreach(int num in nums){
            if(num == miss){
                miss++;
            }
        }
        return miss;
    }
}