//*****************************************************************************
//** 2022. Convert 1D Array Into 2D Array  leetcode                          **
//*****************************************************************************


/**
 * Return an array of arrays of size *returnSize.
 * The sizes of the arrays are returned as *returnColumnSizes array.
 * Note: Both returned array and *columnSizes array must be malloced, assume caller calls free().
 */
int** construct2DArray(int* original, int originalSize, int m, int n, int* returnSize, int** returnColumnSizes) {
    // Check if it's possible to construct the 2D array
    if (originalSize != m * n) 
    {
        *returnSize = 0;
        *returnColumnSizes = NULL;
        return NULL;
    }
    
    // Allocate memory for the 2D array
    int** result = (int**)malloc(m * sizeof(int*));
    *returnColumnSizes = (int*)malloc(m * sizeof(int));
    
    for (int i = 0; i < m; i++) 
    {
        result[i] = (int*)malloc(n * sizeof(int));
        (*returnColumnSizes)[i] = n;  // Each row has `n` columns
    }
    
    // Populate the 2D array
    for (int i = 0; i < originalSize; i++) 
    {
        result[i / n][i % n] = original[i];
    }
    
    *returnSize = m;
    return result;
}