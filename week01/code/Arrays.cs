using System.ComponentModel;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Define a new array of length {length}
        // Step 2: Loop {length} times
        // Step 3: Set the value at the iteration index in the array to (number * i)
        // Step 4: Return the multiples

        double[] multiples = new double[length];

        for (int i = 1; i <= length; i++)
            multiples[i - 1] = number * i; // NOTE: multiples[i - 1] because arrays are 0-indexed

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Iterate amount times
        // Step 2: Store the last item of the list in a variable
        // Step 3: Remove the last item of the list
        // Step 4: Add the stored item to the start of the list

        for (int i = 0; i < amount; i++)
        {
            int lastItem = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            data.Insert(0, lastItem);
        }
    }
}
