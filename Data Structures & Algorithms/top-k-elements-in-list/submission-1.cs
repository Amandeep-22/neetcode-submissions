public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> count = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length; i++)
        {
            if(count.ContainsKey(nums[i]))
            {
                count[nums[i]] = count[nums[i]] + 1;
            }
            else
            {
            count[nums[i]] = 1;
            }
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(
            comparer : Comparer<int>.Create((p1,p2) => p1.CompareTo(p2))
        );

        foreach(var entry in count)
        {
            pq.Enqueue(entry.Key, entry.Value);
            if(pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        int[] ans = new int[k];
        for(int i = 0; i<k ; i++)
        {
            ans[i] = pq.Dequeue();
        }
        return ans;
    }
}
