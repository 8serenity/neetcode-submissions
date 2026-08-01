public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        for(int i = 0; i < nums.Length; i++){
            var currentCheckedValue = nums[i];

            for(int j = 0; j < nums.Length && j != i; j++){
                if(nums[j] == nums[i]){
                    return true;
                }
            }
        }


        return false;
    }
}