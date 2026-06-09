/*
QuickSort
1. Partition
2. Sort left side
3. Sort right side
*/
public class Solution {

    public void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    public int Partition(int[]nums, int lb, int ub){
        int pivotValue = nums[ub];
        int i = lb;
        for(int j = lb; j < ub;j++){
            if(nums[j] < pivotValue){
                Swap(nums,i,j);
                i++;
            }
        }

        Swap(nums,i,ub);
        return i;
    }

    public void QuickSort(int[] nums, int lb, int ub){
        if(lb >= ub)
            return;
        int pivotKey = Partition(nums,lb,ub);
        QuickSort(nums, 0, pivotKey - 1);//Sort Left
        QuickSort(nums, pivotKey + 1, ub);//Sort Right
    }


    public int[] SortArray(int[] nums) {
        QuickSort(nums,0,nums.Length - 1);
        return nums;
    }

}