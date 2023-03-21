public class DaysOfWeek {
    public static void main(String[] args) {
        public void displayWeek() {
            String[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat" };
            try{
                daysOfWeek[7] = "JavaDay";
            }
            catch(ArrayIndexOutOfBoundsException e) {
                System.out.println("Well that looks like an error");
            }
            System.out.println("Guess what I will still print even with an error");
            for(String day : daysOfWeek) {
                System.out.println(day);
            }
        }

        
    }
}
