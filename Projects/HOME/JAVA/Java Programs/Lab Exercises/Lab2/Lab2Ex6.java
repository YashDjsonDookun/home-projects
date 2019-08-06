/*
 * Author: Yash Djson Dookun
 * Purpose: Calculate and print the Volume and Total Surface Area of a sphere
*/

class Lab2Ex6 {
  public static void main(String[] args) {
    /* Assuming that
        Radius: 6.3;
      */

      double Radius, Volume, Total_Surface_Area;
      Radius = 6.3;
      System.out.println("Radius: " + Radius);

      Volume = ((4/3) * (Math.PI) * (Math.pow(Radius,3)));
      System.out.println("The volume of the Sphere is: " + Volume);

      Total_Surface_Area = (4 * (Math.PI) * (Math.pow(Radius, 2)));
      System.out.println("The Total Surface Area of the Sphere is: " + Total_Surface_Area);
  }
}
