/*
* Create a bubble sort application
*/

#include <stdio.h>

int main()
{
    int a[100];
    int numberOfEntries;
    int temp;

    printf("How many digits do you want?\n-->: ");
    scanf("%d", &numberOfEntries);

    printf("Please enter digit:\n");
    for (int i=0; i < numberOfEntries; i++)
    {
        scanf("%d", &a[i]);
    }

    for (int i = 0; i < numberOfEntries -1; i++)
    {
        for (int j=0; j < numberOfEntries -i -1; j++)
        {
            if (a[j]> a[j+1])
            {
                temp = a[j];
                a[j] = a[j+1];
                a[j+1] = temp;
            }
        }
    }

    printf("The entered digits in Ascending order are:\n");
    for (int i=0; i < numberOfEntries; i++)
    {
        printf("%d\n", a[i]);
    }
    return 0;
}
