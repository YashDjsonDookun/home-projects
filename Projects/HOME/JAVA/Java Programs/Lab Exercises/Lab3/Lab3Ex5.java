/*Author: Yash Djson Dookun
 *Task: Write a Java Program that inputs the Length, Width and Height
 *		of a cuboid and calculates and prints the Volume and
 *	    Total Surface Area.
 */
import java.util.Scanner;
public class Lab3Ex5{
	public static void main(String[]args){
		Scanner input = new Scanner(System.in);

		double Length, Width, Height, Volume, TotalSurfaceArea;

		System.out.println("Enter the Length: ");
		Length = input.nextDouble();
		System.out.println("Enter the Width: ");
		Width = input.nextDouble();
		System.out.println("Enter the Height: ");
		Height= input.nextDouble();

		Volume = (Length * Width * Height);
		System.out.println("The Volume of the Cuboid is: " + Volume);

		TotalSurfaceArea = (2 * ((Length * Width) + (Width * Height) + (Length * Height)));
		System.out.println("The Total Surface Area of the Cuboid is: " + TotalSurfaceArea);
	}
}