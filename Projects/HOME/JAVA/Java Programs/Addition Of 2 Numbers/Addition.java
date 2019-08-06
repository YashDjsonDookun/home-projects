import java.util.Scanner;

class Addition {
  public static void main(String[] args) {
    int x,y,z;

    System.out.println("Enter two integers to calculate their sum here ");
    Scanner in = new Scanner(System.in);

    System.out.println("Enter num 1");
    x = in.nextInt();
    System.out.println("Enter num 2");
    y = in.nextInt();

    z = x + y;

    System.out.println("Sum of entered integers = " + z);
    in.close();
  }
}
