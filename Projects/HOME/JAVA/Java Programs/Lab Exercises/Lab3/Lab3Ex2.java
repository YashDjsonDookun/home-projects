
/*
 * Author: Yash Djson Dookun 
 * Purpose: Write a Java program that inputs the
 * length and width of a rectangle and calculates and prints the perimeter and
 * area.
 */
import java.util.Scanner;

class Lab3Ex2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        double length, width, perimeter, area;

        System.out.println("Enter the length of the rectangle: ");
        length = input.nextDouble();
        System.out.println("Enter the width of the rectangle: ");
        width = input.nextDouble();

        perimeter = ((2 * length) + (2 * width));
        area = (length * width);

        System.out.println("The perimeter of the rectangle is: " + perimeter);
        System.out.println("The area of the rectangle is: " + area);

        input.close();
    }
}