import java.util.ArrayList;
import java.util.HashMap;

public class CafeUtil {
    public static int getStreakGoal(int numWeeks) {
        int sum = 0;
        for (int i = 1; i <= numWeeks; i++) {
            sum += i;
        }
        return sum;
    }

    public static double getOrderTotal(double[] prices) {
        double sum = 0;
        for (double price : prices) {
            sum += price;
        }
        return sum;
    }

    public static void displayMenu(ArrayList<String> menuItems) {
        for (String menuItem : menuItems) {
            System.out.printf("%s %s\n", menuItems.indexOf(menuItem), menuItem);
        }
    }

    public static void addCustomer(ArrayList<String> customers) {
        System.out.println("Please enter your name");
        String userName = System.console().readLine();
        System.out.println("Hello, " + userName + "!");
        System.out.printf("There are %s people in front of you", customers.size());
        customers.add(userName);
        System.out.println(customers);
    }

}
