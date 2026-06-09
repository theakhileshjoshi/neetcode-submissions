public class Solution {

    public static void Swap(int[] nums, int left,int right){
        int temp = nums[left]; 
        nums[left] = nums[right]; 
        nums[right] = temp;
    }

    public static int Partition(int[] nums, int left, int right){
        int pivotValue = nums[right];
        int i = left;

        for(int j = left; j < right; j++)
        {
            if (nums[j] < pivotValue)
            {
                Swap(nums,i, j);
                i++;
            }
        }

        Swap(nums,i, right);
        return i;
    }    

    public static void QuickSort(int[] nums, int left,int right){
        if (left >= right)
            return;
        int pivotKey = Partition(nums, left, right);
        QuickSort(nums, left, pivotKey - 1);
        QuickSort(nums, pivotKey + 1, right);
    }

    public void SortColors(int[] nums) {
        QuickSort(nums,0,nums.Length-1);
    }
}