#include <stdio.h>

int main()
{
  enum gender {male, female};

  enum gender myGender;

  myGender = male;

  enum gender anotherGender;

  anotherGender = female;
  _Bool isMale = (myGender == anotherGender);

  printf("%d\n",isMale);
  return 0;
}
