namespace Solutions.Warmup;

public class RunningSum
{
    public int[] Solve(int[] nums)
    {
        int[] result = new int[nums.Length];
        int total = 0;

        // TODO: loop through nums
        //   add the current number to total
        //   store total in result at the same position
        for(int i = 0; i < nums.Length ; i++)
        {
            total = total+nums[i];
            result[i] = total;
        }

        return result;
    }
}