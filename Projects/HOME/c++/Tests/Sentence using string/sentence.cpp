#include <iostream>
#include <string>

int main() {

	std::string Sentence;
	std::cout <<"Enter your name here: " << std::endl;
	 /* instead of using std::cin>>  , we
	     we will try the getline (cin , 'variable') */

	std::getline (std::cin, Sentence);

	std::cout << "Hey guys, this is " << Sentence <<"!" <<  std::endl;

	return 0;
}