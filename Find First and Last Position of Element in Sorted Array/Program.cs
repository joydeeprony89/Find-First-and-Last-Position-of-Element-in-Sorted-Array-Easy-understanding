using System;

namespace Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
       * [5,7,7,8,8,10] target = 6

          [5,7,7,8,8,10], target = 8
       */
    }
  }


  public class Solution
  {
    public int[] SearchRange(int[] nums, int target)
    {
      int l = 0; int r = nums.Length - 1;
      int idx = -1;
      int idx1 = -1;
      int idx2 = -1;
      // Step 1 - Do Binary search first to get the index of the target is present
      while (l <= r)
      {
        int mid = l + (r - l) / 2;
        if (nums[mid] == target)
        {
          idx = mid;
          break;
        }
        if (nums[mid] > target) r = mid - 1;
        else l = mid + 1;
      }

      // if target not found, return -1, -1
      // else if target found
      // we need to check to left and right hand side of the target as inout can have duplicate elements and the input is sorted as well
      if (idx != -1)
      {
        // initialize both the return index as found index
        // will update the resultant index values if any duplicate target element present
        idx1 = idx;
        idx2 = idx;
        // check left side of the found position if any duplicate present
        // check till non target element found
        // idx1 will be updated below
        while (idx1 >= 1 && nums[idx1] == nums[idx1 - 1])
        {
          idx1--;
        }
        // check right side of the found position if any duplicate present
        // check till non target element found
        // idx2 will be updated below
        while (idx2 <= nums.Length - 2 && nums[idx2] == nums[idx2 + 1])
        {
          idx2++;
        }
      }

      return new int[2] { idx1, idx2 };
    }
  }
}
