public class Solution
{
    public int MajorityElement(int[] nums)
    {

        int count = 0;
        int returnvalue = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                returnvalue = num;
            }

            if (num == returnvalue)
            {
                count++;
            }
            else count--;

        }
        return returnvalue;
    }
}