import java.util.Scanner;
import java.text.DecimalFormat;
public class loan {
	public static void main(String[]args){
		Scanner input = new Scanner(System.in);
		DecimalFormat decimalFormat = new DecimalFormat("#,###");
		String surname, otherName;
		double borrow, rate, paybackPeriod, months, monthly, interest;
		int totalAmount, totalInterestAmount;
		/* p = monthly Payment
		 * pv = present value
		 * r = rate
		 * n = number of years (period)
		 */

		System.out.print("Surname: ");
		surname = input.nextLine();
		System.out.print("Other Names: ");
		otherName = input.nextLine();

		do{

			System.out.print("Borrow Amount: Rs ");
			borrow = input.nextInt();
			
			if(borrow < 1){
			System.out.println("Invalid!");
			}

		}
		while (borrow < 1);

		do{

			System.out.print("Yearly Interest Rate: ");
			rate = input.nextInt();

			if(rate < 1){
				System.out.println("Invalid");
			}

		}
		while(rate < 1);

		do{

			System.out.print("Payback Period (In Years): ");
			paybackPeriod = input.nextInt();

			if(paybackPeriod < 1){
				System.out.println("Invalid");
			}
		}
		while (paybackPeriod < 1);

		months = (int)(paybackPeriod * 12);
		interest = (double) ((rate/100)/12);
		monthly = (Math.ceil((interest * borrow) / (1 - (Math.pow((1 + interest),-months)))));
		totalAmount = (int) (monthly * months);
		totalInterestAmount = (int) (totalAmount - borrow);

		System.out.println("------------------------------------------------------");
		System.out.println("Surname: " + surname + "    " + "Other Names: " + otherName);
		System.out.println("------------------------------------------------------");
		System.out.println("Amount to Borrow     : Rs " + decimalFormat.format(borrow));
		System.out.println("Yearly Interest      : " + rate + "%");
		System.out.println("Payback Over         : " + paybackPeriod + " years");

		System.out.println("------------------------------------------------------");
		System.out.println("Monthly Repayments   : Rs " +  decimalFormat.format(monthly));
		System.out.println("Total Interest Amount: Rs " +  decimalFormat.format(totalInterestAmount));
		System.out.println("Total Amount Payable : Rs " +  decimalFormat.format(totalAmount));
		System.out.println("------------------------------------------------------");

		input.close();
	}	
}