public class Solution {
    public int NumIslands(char[][] grid) {
        
        int ans = 0;
        for(int i = 0; i<grid.Length; i++)
        {
            for(int j = 0; j<grid[0].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    grid[i][j] = '0';
                    ans++;
                    dfs(grid, i+1, j);
                    dfs(grid, i, j+1);
                    dfs(grid, i-1, j);
                    dfs(grid, i, j-1);
                }
            }
        }
        return ans;
    }

    void dfs(char[][] grid, int i, int j)
    {
        if(i<0 || j<0  || i>=grid.Length || j>=grid[0].Length )
        {
            return;
        }
        else if(grid[i][j] == '0')
        {
            return;
        }
        else
        {
            grid[i][j] = '0';
            dfs(grid, i+1, j);
            dfs(grid, i, j+1);
            dfs(grid, i-1, j);
            dfs(grid, i, j-1);
        }
    }
}
