import java.util.HashMap;

public class Restaurant {
 public static void main(String[] args) {

HashMap<String,Integer> restaurantMenu = new HashMap<String,Integer>();

    restaurantMenu.put("Turkey", 13);
     restaurantMenu.put("Naan Pizza", 11);
      restaurantMenu.put("Cranberry Kale Salad", 10);

  /*    System.out.println(restaurantMenu.get("Naan Pizza")); ----->   This will print the value associated with Naan Pizza. */

/*  System.out.print(restaurantMenu.size());   ----->      This will print the size of the HashMap */

  for (String item : restaurantMenu.keySet()) {

    System.out.println("A " + item +" costs " + restaurantMenu.get(item) + " dollars.");
  }
 }
}






/*  Although the name of the data structure might not make sense to you immediately, think of it as a real-life dictionary.
A dictionary contains a set of words and a definition for each word. A HashMap contains a set of keys and a value for each key.

If we look up a word in a dictionary, we can get the definition. If you provide a HashMap with a key that exists, you can
retrieve the value associated with the key.

*/
