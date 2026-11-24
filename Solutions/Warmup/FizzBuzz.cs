namespace Solutions.Warmup;

// Fizz Buzz (Easy)
// https://leetcode.com/problems/fizz-buzz/
// On LeetCode, the method is called: FizzBuzz  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Loop i from 1 to n (inclusive), building a List<string>.
//   2. Check i % 15 == 0 (FizzBuzz) BEFORE i % 3 and i % 5. Why does the order matter?
//   3. Otherwise add i.ToString().
public class FizzBuzz
{
    public IList<string> Solve(int n)
    {
        List<string> result = new List<string>();

        for(int i=1;i<= n; i++)
        {
            
            if(i%3==0 && i % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                result.Add("Buzz");
            }
            else if(i%3==0 )
            {
                result.Add("Fizz");
            }
            else
            {
                result.Add(i.ToString());
            }
        }

        return  result;
        
    }
}
