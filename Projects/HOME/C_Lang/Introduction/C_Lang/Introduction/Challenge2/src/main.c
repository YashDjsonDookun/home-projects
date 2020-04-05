#include <stdio.h>

int main()
{
  double width, height;
  double area = 0.0;
  double perimeter = 0.0;

  // Input Height
  printf("Please enter the height of the rectangle: ");
  scanf("%lf", &height);

  // Input Width
  printf("Please enter the width of the rectangle: ");
  scanf("%le", &width);

  //Calculate perimeter
  perimeter = (2.0 * (height + width));

  //Calculate area
  area = (width * height);

  // Display Width and Height
  printf("\nHeight: %.2f\nWidth: %.2f\n", height, width);

  // Display Area and Perimeter
  printf("Area: %.2f\nPerimeter: %.2f\n", area, perimeter );
  return 0;
}
