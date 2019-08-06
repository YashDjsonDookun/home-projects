/*
* Author: Yash Djson Dookun
* Purpose: Calculate and Print the hypotenus, perimeter and area of a Triangle
*/
import java.io.*;

class Lab2Ex1 {
  public static void main(String[] args) {
    /*
    * Assuming:
                Base -> 5.0,
                Height -> 10.0
    */
    double Height = 10.0;
    double Base = 5.0;
    double Hypotenus;
    double Perimeter;
    double Area;

    // Assuming that 'height = Opposite' and 'base = adjacent', then Hypotenus = (height / base)
    Hypotenus = Math.sqrt(Math.pow(Base,2) + Math.pow(Height,2));

    //Perimeter = distance al around; there base + height + hypotenus
    Perimeter = Base + Height + Hypotenus;

    //Area of a Triangle = ((0.5) * Base *  Height)
    Area = ((0.5) * Base * Height);

    System.out.println("Height of the Triangle: " + Height);
    System.out.println("Base of the Triangle: " + Base);
    System.out.println("The Hypotenus of the Triangle is: " + Hypotenus);
    System.out.println("The Perimeter if the Triangle is: " + Perimeter);
    System.out.println("The Area of the Triangle is: " + Area);
  }
}
