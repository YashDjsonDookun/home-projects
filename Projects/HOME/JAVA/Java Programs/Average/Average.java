import java.util.Scanner;
import java.math.*;
import java.util.ArrayList;
import java.util.Arrays;


public class Average {
    public static void main(String[] args) {

        //This allows for user input
        Scanner in = new Scanner(System.in);

        int count = 0;
        int i = 0;
        
        /*This will be used to know how many elements are there going to be in the array*/
        /*This is what will be used to calculate the average */
        System.out.println("How many numbers do you wish to input?");
        count = in.nextInt();

        //This creates the array
       double[] Number_list = new double[count];

       double sum = 0;

       /*Ths allows us to input the digits in the array to calculate the average*/
       while (i < count) {
           System.out.println("Enter digit here: ");
           Number_list[i] = in.nextDouble();
           i++;
       }

       //This is used to find the sum of all the digits
       for (double number : Number_list) {
           sum += number;
       }
/*This is to print the numbers that the user input */

       System.out.println("List of Numbers is: " + Arrays.toString(Number_list));
       in.close();
/*This part Calculates the average */

           double average = 0;
           average = sum / count;

           System.out.println("The average is: " + average);  //This prints the average
    }
}