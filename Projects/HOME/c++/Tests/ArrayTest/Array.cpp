#include <iostream>

int main()
{
  std::cout << "Hey, Welcome to my simple test program for Arrays!" << std::endl;

  int *ptr = NULL;

  std::cout << "How many digits do you wish to enter? ";
  int num;

  ptr = new int[num];
  std::cin >> num;

  for (int i=1; i < (num + 1); i++)
  {
    std::cout <<"Enter digit " << i << " here: ";
    std::cin >> ptr[i];
  }

  std::cout << "The digits that you entered were: " <<std::endl;
  for (int j = 1; j < (num + 1); j++)
  {
    std::cout << ptr[j]  << std::endl;
  }

  system("pause");
  return 0;
}
