/*
 * Author: Yash Djson Dookun
 * Purpose: Calculate and print the Volume and Total Surface Area of a Cuboid
*/

import java.io.*;

class Lab2Ex5 {
	public static void main(String[] args) {
		
		/* Assuming: 
			Length: 15.3;
			Width: 7.5;
			Height: 5.0;
		*/

		double Length, Height, Width, Volume, Total_Surface_Area;

		Length = 15.3;
		System.out.println("Length: " + Length);
		Width = 7.5;
		System.out.println("Width: " + Width);
		Height = 5;
		System.out.println("Height: " + Height);

		Volume = (Length * Width * Height);
		System.out.println("The Volume of the Cuboid is: " + Volume);

		Total_Surface_Area = (2 * ((Length * Width) + (Width * Height) + (Length * Height)));
		System.out.println("The Total Surface Area of the Cuboid is: " +Total_Surface_Area);
	}
}