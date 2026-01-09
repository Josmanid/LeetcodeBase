using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeBase
{
    public class Solution
    {
        public int[] GetConcatenation(int[] nums) {
            // Get the length of the original array
            int n = nums.Length;

            // Create a new array with double the length to hold the concatenated result
            int[] ans = new int[2 * n];

            // Iterate through each element of the original array
            for (int i = 0; i < n; i++)
            {
                // Copy the current element to the first half of the result array
                // (positions 0, 1, 2 when n=3)
                ans[i] = nums[i];

                // Copy the same element to the second half of the result array
                // (positions 3, 4, 5 when n=3)
                ans[i + n] = nums[i];
            }

            return ans;
        }

        public int[] Shuffle(int[] nums, int n) {
            int[] ans = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                ans[2 * i] = nums[i];
                ans[2 * i + 1] = nums[i + n];

            }
            return ans;


        }
        public int FindMaxConsecutiveOnes(int[] nums) {
            int currentCount = 0;
            int maxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)  // Tjek kun det nuværende element
                {
                    // Øg currentCount
                    currentCount = currentCount + 1;
                    // Opdater maxCount hvis currentCount er større
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    // Nulstil currentCount
                    currentCount = 0;
                }
            }
            return maxCount;
        }

        public int[] FindErrorNums(int[] nums) {
            //find størrelsen
            int n = nums.Length;
            //opret tælle array vi skal indexe fra 1 af.
            int[] count = new int[n + 1];

            foreach (int num in nums)
            {
                count[num]++;// kigger på værdien i hver index og lægger derefter til det pågældende index værdi i count.
            }

            int duplicate = 0;
            int missing = 0;

            for (int i = 1; i <= n; i++)
            {
                // Et tal kommer præcis 2 gange 
                if (count[i] == 2)
                {
                    duplicate = i;
                }
                // Et tal kommer præcis 0 gange
                if (count[i] == 0)
                {
                    missing = i;
                }
                // Alle andre tal kommer præcis 1 gang
            }
            return new int[] { duplicate, missing };
        }

        /// <summary>
        /// VI sammenligner hvert array index med alle de andre, her skal tænkes nested loop.
        /// Derudover vil vi ikke sammenligne med et tal med sig selv derfor er j != i nødvendig
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SmallerNumbersThanCurrent(int[] nums) {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if(j != i && nums[j] < nums[i])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }
            return result;
        }
    }
}
