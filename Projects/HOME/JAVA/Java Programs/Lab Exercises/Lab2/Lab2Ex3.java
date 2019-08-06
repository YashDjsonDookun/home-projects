/*
 * Author: Yash Djson Dookun
 * Purpose: Calculate and print the Circumference and Area of a Circle
*/
import java.io.*;

class Lab2Ex3 {
	public static void main(String[] args) {
		/*Assuming that:
			Radius,r = 7.3;
		*/

		double radius = 7.3;	
		double pi = 3.141592654;
		double Area, Circumference;

		System.out.println("Radius: " + radius);

		Area = ((pi) * (Math.pow(radius,2)));
		Circumference = (2 * pi * radius);

		System.out.println("The Area of the Circle is: " + Area);
		System.out.println("The Circumference of the Circle is: " + Circumference);
	}
}