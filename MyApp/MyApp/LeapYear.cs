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
        int year = Convert.ToInt32(Console.ReadLine());
        
        if(isLeapYear(year)) {
            Console.WriteLine("yay");
        }else {
            Console.WriteLine("nay");
        }
    }

}
