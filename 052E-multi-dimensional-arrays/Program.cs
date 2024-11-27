using System;

/*
 *  Implement a method FindMax that:
 *  Takes a two-dimensional array of integers.
 * Returns the maximum value in the array.
 * If the array is empty (any dimension is zero), it should return -1.
 */

// 1. define the method signature: 2D array of integers and returns an integer
static int FindMax(int[,] numbers)
{
    // 2. check if the array is empty
    int height = numbers.GetLength(0); // Number of rows
    if (height == 0)
    {
        return -1;
    }

    int width = numbers.GetLength(1); // Number of columns
    if (width == 0)
    {
        return -1;
    }
    
    // 3. initialize the max variable: assuming the first element is the max
    int max = numbers[0, 0];
    for (var i = 0; i < height; ++i) // iterate over the rows
    {
        for (var j = 0; j < width; ++j) // iterate over the columns
        {
            var number = numbers[i,j]; // if numbers[i,j] is greater than max, update max
            if (number > max)
            {
                max = number; // update the max value if a larger number is found
            }
        }
    }
        
    return max;
}
