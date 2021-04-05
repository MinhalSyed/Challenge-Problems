//https://leetcode.com/discuss/interview-question/819577/Throttling-Gateway-Hackerrank


/*
* number of Transactions in any given second cannot exceed 3
* number of Transactions in any given 10 second period cannot exceed 20.
* number of Transactions in any given minute cannot exceed 60.
*/


public class Solution
{

    public int DroppedRequests(int[] requestTimes)
    {
        int droppedRequests = 0;

        for(int i = 1; i < requestTimes.Count(); i++)
        {
            droppedRequests++;
        }

        return droppedRequests;
    }
}