/* Name: Yash Djson Dookun
 * Task: Create a C program that converts the numbers of minutes to days and years
 */

#include <stdio.h>

int main()
{
	printf("Enter amount of minutes: ");
	int inputMins;
	scanf("%d", &inputMins);

	// Convert minutes to years
	double minToYears;
	minToYears = (inputMins / 525600);

	//Convert years to days
	double yearsToDays;
	yearsToDays = (minToYears * 365);

	printf("minutes: %d\nYears: %f\nDays: %f\n", inputMins, minToYears, yearsToDays);
	return 0;
}
