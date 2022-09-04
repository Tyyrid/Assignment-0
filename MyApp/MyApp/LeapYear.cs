// See https://aka.ms/new-console-template for more information

namespace MyApp;

//true
// divideres med 4
// ikke med 100, medmindre de kan divideres med 400

public class LeapYear {
    
    public bool IsALeapYear(int year) {
        if(year <= 0) {
            return false;
        }

        if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) {
            return true;
        }
    return false;
    }

}
