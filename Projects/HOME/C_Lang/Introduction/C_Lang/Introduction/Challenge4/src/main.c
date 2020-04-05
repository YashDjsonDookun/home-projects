/* Name: Yash Djson Dookun
 * Task: Create a C program that converts the numbers of minutes to days and years
 */


//my answer (bad but kinda works)

// #include <stdio.h>

// int main()
// {
// 	printf("Enter amount of minutes: ");
// 	int inputMins;
// 	scanf("%d", &inputMins);

// 	// Convert minutes to years
// 	double minToYears;
// 	minToYears = (inputMins / 525600);

// 	//Convert years to days
// 	double yearsToDays;
// 	yearsToDays = (minToYears * 365);

// 	printf("minutes: %d\nYears: %f\nDays: %f\n", inputMins, minToYears, yearsToDays);
// 	return 0;
// }



#include <stdio.h>
#include <stdlib.h>

int main()
{
	int minutesEntered = 0;
	double years = 0.0;
	double days = 0.0;
	double minutesInYear = 0;

	printf("Please enter the number of minutes: ");

	//get input from user
	scanf("%d", &minutesEntered);

	minutesInYear = (60 * 24 * 365);

	years = (minutesEntered / minutesInYear);
	days = ((minutesEntered / 6.0) / 24.0);

	printf("%d minutes is approximately %f years and %f days\n", minutesEntered, years, days);

	return 0;
}