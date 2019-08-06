import java.util.Scanner;
import java.text.DecimalFormat;
import java.text.NumberFormat;

public class task1 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		DecimalFormat numberFormat = new DecimalFormat("#.#");

		Float inputTempt;
		System.out.print("Input Baby Temperature in Degrees Celcius: ");
		inputTempt = input.nextFloat();

		// converts to 1 decimal place
		inputTempt = Float.parseFloat(numberFormat.format(inputTempt));

	}
}