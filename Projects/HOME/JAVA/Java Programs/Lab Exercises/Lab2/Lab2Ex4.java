/*
 * Author: Yash Djson Dookun
 * Purpose: Calculate and Print the Volume and Total Surface Area of a Cylinder
*/

import java.io.*;
class Lab2Ex4 {
	public static void main(String[] args) {
		double Volume;
		double Total_Surface_Area;
		double Height, Radius; 

		/* Assuming that:
				Radius: 8.0;
				Height: 20.2;
		*/

		Radius = 8.0;
		Height= 20.2;

		System.out.println("Height: " + Height);
		System.out.println("Radius " + Radius);

		//Volume of a Cylinder is: (pi * r^2 * h)
		Volume = ((Math.PI) * (Math.pow(Radius,2)) * (Height));
		System.out.println("The Volume of the Cylinder is: " + Volume);

		//Total Surface Area of a Cylinder: ((2 * pi * r^2) + (2 * Math.PI * r * h))
		Total_Surface_Area = ((2 * Math.PI * Math.pow(Radius,2)) + (2 * Math.PI * Radius * Height));
		System.out.println("The Total Surface Area of the Cylinder is: " + Total_Surface_Area);
	}
}