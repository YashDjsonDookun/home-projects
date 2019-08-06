
/*
 * Author: Yash Djson Dookun
 * Purpose: Write a Java program that inputs the base and height of a right angle triangle and calculates
            and prints the hypotenuse, perimeter and area.
*/

import java.util.Scanner;

class Lab3Ex1 {
  public static void main(String[] args) {

    Scanner input = new Scanner(System.in);
    double Height, Base, Hypotenuse, Area, Perimeter;

    System.out.println("Enter the Height: ");
    Height = input.nextDouble();

    System.out.println("Enter the Base: ");
    Base = input.nextDouble();

    // Assuming that 'height = Opposite' and 'base = adjacent', then Hypotenus =
    // (height / base)
    Hypotenuse = Math.sqrt(Math.pow(Base, 2) + Math.pow(Height, 2));

    // Perimeter = distance al around; there base + height + hypotenus
    Perimeter = Base + Height + Hypotenuse;

    // Area of a Triangle = ((0.5) * Base * Height)
    Area = ((0.5) * Base * Height);

    System.out.println("Height of the Triangle: " + Height);
    System.out.println("Base of the Triangle: " + Base);
    System.out.println("The Hypotenus of the Triangle is: " + Hypotenuse);
    System.out.println("The Perimeter if the Triangle is: " + Perimeter);
    System.out.println("The Area of the Triangle is: " + Area);
    input.close();
  }
}
