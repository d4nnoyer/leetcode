namespace LeetCodeSolutions.Solutions.Queue.Easy;

public class RecentCounter {
    
    private readonly Queue<int> calls;
    public RecentCounter()
    {
        calls = new Queue<int>();
    }
    
    public int Ping(int t)
    {
        calls.Enqueue(t);
        while (calls.TryPeek(out var callTimestamp) && callTimestamp < t - 3000)
            calls.Dequeue();
        return calls.Count;
    }
}