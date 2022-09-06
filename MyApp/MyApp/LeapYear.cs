// See https://aka.ms/new-console-template for more information

namespace MyApp;

//true hvis:
// divideres med 4
// ikke divideres med 100, medmindre det kan divideres med 400

public class LeapYear {
    
    public bool isLeapYear(int year) {
        if(year <= 0) {
            return false;
        }

        if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) {
            return true;
        }
    return false;
    }
    

    public void isLeapYearWithUserInput() {
    Console.WriteLine("Enter year: ");
    int year = 0;
        try {
            year = Convert.ToInt32(Console.ReadLine());

            if(year < 1582) {
                Console.WriteLine("Please enter a year after 1582.");
            }else if(isLeapYear(year)) {
            Console.WriteLine("yay");
            }else {
            Console.WriteLine("nay");
            }

        }catch(Exception) {
            Console.WriteLine("Please enter a valid year" );
            //Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
        }


        /*var integerEntered = false;
        int year = 0;

        while (!integerEntered) {
            Console.WriteLine("Enter year: ");
            var entered = Console.ReadLine();
            integerEntered = int.TryParse(entered, out year);
                if (!integerEntered)
                    Console.WriteLine("That was no valid integer. Please try again.");
        }

        if(isLeapYear(year)) {
            Console.WriteLine("yay");
            }else {
            Console.WriteLine("nay");
            }*/
    }
}
