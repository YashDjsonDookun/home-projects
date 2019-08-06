/*
 * Author: Yash Djson Dookun
 * Purpose: Calculate and print the Area and Perimeter of a Rectangle
*/
import java.io.*;
class Lab2Ex2 {
	public static void main(String[] args) {
	  	
	  	/*Assuming that:
	  			Length = 15.0;
	  			Width = 7.5;
	  	*/

	  	double Length, Width, Area, Perimeter;

	  	Length = 15.0;
	  	Width = 7.5;

	  	Area = (Length * Width);
	  	Perimeter = ((2*Length) + (2*Width));

	  	System.out.println("Length: " + Length);
	  	System.out.println("Width: "  + Width);
	  	System.out.println("The Area of the Rectangle is: " + Area);
		System.out.println("The Perimeter of the Rectangle is: " + Perimeter);

	  }  
}
