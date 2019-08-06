
/*
 * Author: Yash Djson Dookun
 * Purpose: Write a Java program that inputs the radius of 
 * a circle and calculates and prints the circumference and area.
 */
import java.util.Scanner;

class Lab3Ex3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        double radius, circumference, area;

        System.out.println("Enter the radius of the circle: ");
        radius = input.nextDouble();

        area = ((Math.PI) * (Math.pow(radius, 2)));
        circumference = (2 * Math.PI * radius);

        System.out.println("The Circumference of the circle is: " + circumference);
        System.out.println("The Area of the circle is: " + area);

        input.close();
    }
}