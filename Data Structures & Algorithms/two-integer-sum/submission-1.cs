public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indices = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            indices[nums[i]] = i;
        }

        for(int i = 0; i < nums.Length; i++){
            var difference = target - nums[i];

            if(indices.ContainsKey(difference) && indices[difference] != i){
                return new [] {i, indices[difference]};
            }

        }

        

        return null;
    }
}
