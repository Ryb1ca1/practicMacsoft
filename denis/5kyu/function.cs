public class Kata
{
    public static int[] MoveZeroes(int[] nums)
    {
        int writeIndex = 0;

        for (int readIndex = 0; readIndex < nums.Length; readIndex++) {
            if (nums[readIndex] != 0) {
                nums[writeIndex] = nums[readIndex];
                writeIndex++;
            }
        }

        while (writeIndex < nums.Length) {
            nums[writeIndex] = 0;
            writeIndex++;
        }
        return nums;
    }
}