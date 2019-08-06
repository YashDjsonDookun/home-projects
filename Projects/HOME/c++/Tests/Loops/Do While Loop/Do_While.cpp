/* This will be an example of how a Do While Loop
	can be used in a C++ program */

#include <iostream>
#include <string>

std::string Name() {

	std::cout << "Enter Your Name: " ;
	std::string EnterName;
	std::getline (std::cin , EnterName);
	std::cout << "Hey, " << EnterName << "! Welcome to this very Ambiguous Testing Program!!!" << std::endl;
	return EnterName;
}

void std::string Answer() {
	std::cout << "Would you like to play a little game? " ;
	std::string answer;
	std::getline (std::cin , answer);
}


int main() {

	Name();
	Answer();


	return 0;
}