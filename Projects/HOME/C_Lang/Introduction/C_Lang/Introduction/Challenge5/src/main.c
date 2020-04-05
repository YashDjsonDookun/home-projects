/* Author: Yash Djson Dookun
 * Task: Create a C program that displays the byte size of basic data types
 *		 supported in C
 */

#include <stdio.h>
#include <stdlib.h>

int main()
{
	// printf("%zd\n", sizeof(int));
	// printf("%zd\n", sizeof(char));
	// printf("%zd\n", sizeof(long));
	// printf("%zd\n", sizeof(long long));
	// printf("%zd\n", sizeof(double));
	// printf("%zd\n", sizeof(long double));

	printf("%u\n", sizeof(int));
	printf("%u\n", sizeof(char));
	printf("%u\n", sizeof(long));
	printf("%u\n", sizeof(long long));
	printf("%u\n", sizeof(double));
	printf("%u\n", sizeof(long double));

	return 0;
}