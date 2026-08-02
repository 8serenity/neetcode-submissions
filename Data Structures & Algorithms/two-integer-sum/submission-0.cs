public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++){
            var firstNumber = nums[i];



            for(int j = 0; j < nums.Length; j++){
                if(j == i) continue;

                var secondNumber = nums[j];


                if (firstNumber + secondNumber == target){
                    return new [] {i,j};
                }
            }
        }
        return null;
    }
}
