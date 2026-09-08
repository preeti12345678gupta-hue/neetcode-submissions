public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int count = 0;
        int left = 0;
        int right = people.Length - 1;
        while(left <= right){
            if(people[left] + people[right] <= limit){
                left++;
            }
            right--;
            count++;
        }

        return count;
    }
}