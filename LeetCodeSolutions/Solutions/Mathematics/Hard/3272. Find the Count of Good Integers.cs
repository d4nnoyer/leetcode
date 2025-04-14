namespace LeetCodeSolutions.Solutions.Mathematics.Hard;

public class Find_the_Count_of_Good_Integers {
    
    public static long CountGoodIntegers(int n, int k) {
        var set = new HashSet<string>();
        
        var baseVal = (int)Math.Pow(10, (n - (double)1) / 2);
        var skip = n & 1;
        
        for (var i = baseVal; i < baseVal * 10; i++) {
            var s = i.ToString();
            s += new string(s.Reverse().Skip(skip).ToArray());
            var palindromicInteger = long.Parse(s);
            
            if (palindromicInteger % k == 0) 
            {
                var chars = s.ToCharArray();
                System.Array.Sort(chars);
                set.Add(new string(chars));
            }
        }

        var factorial = new long[n + 1];
        factorial[0] = 1;
        for (var i = 1; i <= n; i++) 
            factorial[i] = factorial[i - 1] * i;

        long ans = 0;
        foreach (var s in set) 
        {
            var cnt = new int[10];
            foreach (var c in s) 
                cnt[c - '0']++;
            
            var tot = (n - cnt[0]) * factorial[n - 1];
            foreach (var x in cnt) 
                tot /= factorial[x];
            ans += tot;
        }

        return ans;
    }
}