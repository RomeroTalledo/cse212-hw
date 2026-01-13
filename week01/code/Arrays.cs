using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

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
         // This function returns a list of multiples of the given number.
        // The amount of multiples returned depends on the 'length' parameter.
        // 1. Create a list to store the multiples.
        // 2. Use a for loop to iterate from 1 up to the given length.
        // 3. Multiply the current index by the given number and add the result to the list.
        // 4. Convert the list to an array and return it for the corresponding tests.

        List<double> numbers = new();
        for (int i = 1; i <= length; i++)
        {
            double x = i * number;
            numbers.Add(x);
        }

        return numbers.ToArray(); // replace this return statement with your own
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
        // This function rotates the list to the right by moving elements.
        // 1. Repeat the process 'amount' times.
        // 2. On each iteration, store the last element of the list.
        // 3. Remove the last element from the list.
        // 4. Insert the stored element at the beginning of the list.
        int x = 0;
        while (x < amount)
        {
            x += 1;
            int lastElement = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            data.Insert(0, lastElement);
        }

        
    }
}
