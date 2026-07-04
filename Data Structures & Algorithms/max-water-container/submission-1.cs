public class Solution {
    public int MaxArea(int[] heights) {

        int l = 0; 
        int r = heights.Length-1;

        int ans = 0;
        while(l<r)
        {
            int min = Math.Min(heights[l],heights[r]);
            ans = Math.Max(ans,min*(r-l));

            if(heights[l]>heights[r])    
                r--;
            else
                l++;
        }    
        return ans;
    }
}
