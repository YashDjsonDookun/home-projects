import java.util.Scanner;

public class circumference {
    public static void main(String[] args) {
        double pi = 3.141592654;
        double radius = 0;

        Scanner in  = new Scanner(System.in);
        
        System.out.println("Enter the Radius: ");
        radius = in.nextDouble();

       double Circumference = (2 * pi * radius);

        System.out.println("The Circumference of the Circle is: " + Circumference + ".");
        in.close();



    }
}
     
    