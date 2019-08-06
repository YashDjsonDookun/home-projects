#include <stdio.h>

//Hint


/*
* How to Run:
*   ./a.out <type something here>
*/


int main(int argc, char *argv[])
{

  printf("Number of Arguments: %i\n", argc);

  for (int i = 0; i < argc; i++)
  {
      char *argument = argv[i];
      // printf("Argument %d", i ,": %s\n", argument);
      printf("Argument %d is: %s\n", i,argument);
  }

  return 0;
}
