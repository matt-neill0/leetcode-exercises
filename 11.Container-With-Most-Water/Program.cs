public class Solution {
    static void Main() {
        int[] height = new int[] {1,8,6,2,5,4,8,3,7};
        Solution solution = new Solution();
        Console.WriteLine(solution.MaxArea(height));
    }

    public int MaxArea(int[] height){
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;
        while(left < right){
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea);
            if(height[left] < height[right]){
                left++;
            } else {
                right--;
            }
        }
        return maxArea;
    }
}