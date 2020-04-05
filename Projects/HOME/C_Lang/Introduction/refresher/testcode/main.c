/*
 * Sum the odd and even numbers, respectively, from 1 to a given upperbound.
 * Also compute the absolute difference.
 * (SumOddEven.c)
 */
#include <stdio.h>

int main()
{
    int sumOdd = 0;  // For accumulating odd numbers, init to 0
    int sumEven = 0; // For accumulating even numbers, init to 0
    int upperBound;  // Sum from 1 to this upperbound
    int absDiff;  // The absolute difference between the two sum

    // Prompt user for an upperbound
    printf("Enter the upperbound: ");
    scanf("%d", &upperBound); // Use %d to read an integer

    // Use a while-loop to repeatedly add 1,2,3,..., to the upperbound
    int number = 1;
    while (number <= upperBound)
    {
        if (number % 2 == 0) // Even number
        {
            sumEven += number;  // Add number to SumEven
        }
        else // Odd number
        {
            sumOdd += number;  // Add number to SumOdd
        }
        number++;
    }

    // Computer the absolute abstract difference between the two sum
    if (sumOdd > sumEven)
    {
        absDiff = sumOdd - sumEven;
    }
    else
    {
        {
            absDiff = sumEven - sumOdd;
        }
    }

    // Print the results
    printf("The sum of odd numbers is %d.\n", sumOdd);
    printf("The sum of even numbers is %d.\n", sumEven);
    printf("The absolute difference is %d.\n", absDiff);
    
    return 0;
}
