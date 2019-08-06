#include <stdio.h>

int main()
{
  enum Company {GOOGLE, FACEBOOK, XEROX, YAHOO, EBAY, MICROSOFT};

  enum Company variable1;
  enum Company variable2;
  enum Company variable3;

  variable1 = XEROX;
  variable2 = GOOGLE;
  variable3 = EBAY;

  printf("The value of variable1 is: %d\n", variable1);
  printf("The value of variable2 is: %d\n", variable2);
  printf("The value of variable3 is: %d\n", variable3);

  return 0;
}
