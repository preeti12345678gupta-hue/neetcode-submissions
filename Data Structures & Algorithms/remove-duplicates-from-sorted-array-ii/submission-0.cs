public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int j = 0;
        for(int i = 0; i < nums.Length; i++){
            if(j < 2 || nums[i] != nums[j - 2]){
                nums[j] = nums[i];
                j++;
            }
        }

        return j;
        
    }
}