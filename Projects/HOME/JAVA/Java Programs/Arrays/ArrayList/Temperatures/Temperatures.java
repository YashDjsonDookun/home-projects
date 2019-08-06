import java.util.ArrayList;

public class Temperatures {

  public static void main(String[] args) {
    ArrayList<Integer> weeklyTemperatures = new ArrayList<Integer>();
     weeklyTemperatures.add(78);
      weeklyTemperatures.add(67);
       weeklyTemperatures.add(89);
        weeklyTemperatures.add(94);
    weeklyTemperatures.add(2,111); /*This adds an entry to index 2, therefore shifts its current entry and the rest 1 index below */

for (int i = 0; i < weeklyTemperatures.size(); i++) {
  System.out.println(weeklyTemperatures.get(i));

  /* Alternatively, the following lines of codes could have been used as a shortcut:

                                          for (Integer temperature : weeklyTemperatures){
                                           System.out.println(temperature);
                                        }
*/
}
  }
}
