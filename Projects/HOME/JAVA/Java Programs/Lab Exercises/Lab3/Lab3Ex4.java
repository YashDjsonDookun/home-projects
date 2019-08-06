/*
 *Author: Yash Djson Dookun
 *Task: Write a Java program that inputs the radius and height of a 
 *      Cylinder and claculates and prints the Volume and Total
 *		Surface Area.
*/
import java.util.Scanner;
public class Lab3Ex4 {
	public static void main(String[]args){
		Scanner input = new Scanner(System.in);

		double Radius, Height, Volume, TotalSurfaceArea;

		System.out.println("Enter the radius: ");
		Radius = input.nextDouble();
		System.out.println("Enter the Height: ");
		Height = input.nextDouble();

		//Volume of a Cylinder is: (pi * r^2 * h)
		Volume = ((Math.PI) * (Math.pow(Radius,2)) * (Height));
		System.out.println("The Volume of the Cylinder is: " + Volume);

		//Total Surface Area of a Cylinder: ((2 * pi * r^2) + (2 * Math.PI * r * h))
		TotalSurfaceArea = ((2 * Math.PI * Math.pow(Radius,2)) + (2 * Math.PI * Radius * Height));
		System.out.println("The Total Surface Area of the Cylinder is: " + TotalSurfaceArea);

		input.close();
	}
}