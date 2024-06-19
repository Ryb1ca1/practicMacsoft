public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        int rows = array.Length;
        int cols = array[0].Length;
        int totalElements = rows * cols;
        int[] result = new int[totalElements];

        int top = 0, bottom = rows - 1, left = 0, right = cols - 1;
        int index = 0;

        while (index < totalElements)
        {
            for (int i = left; i <= right && index < totalElements; i++)
                result[index++] = array[top][i];
                top++;

            for (int i = top; i <= bottom && index < totalElements; i++)
                result[index++] = array[i][right];
                right--;

            if (index < totalElements && top <= bottom)
            {
                for (int i = right; i >= left && index < totalElements; i--)
                result[index++] = array[bottom][i];
                bottom--;
            }

            if (index < totalElements && left <= right)
            {
                for (int i = bottom; i >= top && index < totalElements; i--)
                result[index++] = array[i][left];
                left++;
            }
        }

        return result;
    }

}