// Pattern: HashMap - complement lookup
// Time: O(n) | Space: O(n)
public class TwoSum {
    public int[] Solve(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };
            map[nums[i]] = i;
        }
        return new int[] {};
    }
}
