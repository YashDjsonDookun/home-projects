import java.util.Scanner;
import java.math.*;

public class Area {
    public static void main(String[] args) {
        
        Scanner in = new Scanner(System.in);

        double r = 0;
        double pi = 3.141592654;

        System.out.println("Enter radius down here:");

        r = in.nextDouble();

        double area = ((pi) * Math.pow(r,2));       //math.pow is used for powers; in this case it is 'r power 2'

        System.out.println("The Area of the Circle is: " + area + ".");
        in.close();

    }
}