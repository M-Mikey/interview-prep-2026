// Pattern: HashSet - detect seen elements
// Time: O(n) | Space: O(n)
public class ContainsDuplicate {
    public bool Solve(int[] nums) {
        var seen = new HashSet<int>();
        foreach (int num in nums) {
            if (seen.Contains(num)) return true;
            seen.Add(num);
        }
        return false;
    }
}
