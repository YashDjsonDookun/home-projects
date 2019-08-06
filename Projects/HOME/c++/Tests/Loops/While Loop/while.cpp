#include <iostream>
using namespace std;

/* This is a simple C++ program that will use a While Loop
	to create a custom coutdown based a 'user-input'
		starting number.  */

int main() {

	int StartingNumber;
	std::cout << "Enter a Starting Number: ";
	std::cin >> StartingNumber;

	while (StartingNumber > 0) {
		std::cout << StartingNumber << ", ";
		--StartingNumber;
	}

	std::cout << "FIRE!" << std::endl;
	return 0;
}