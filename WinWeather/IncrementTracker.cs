/*
 * File: WeatherProcessor.cs
 * 
 * Author: Carl-Gustav Høivang (carl4020@edu.rybners.dk)
 * Date: April 2nd 2024 - May 8th 2024
 * Course: Programmering B
 * 
 * Summary of file:
 *  The file is a container for the IncrementTracker class that is meant to be
 *  used as a part of an easy solution for keeping track of dates. Because
 *  instead of handling DateTime objects, the program just has to handle a much
 *  less resource heavy Integer, that then can be added on to the singular
 *  DateTime object once, rather than having to do it each time the "increment"
 *  is updated. This is because the "dayIncrement" really is only used for
 *  sending API-requests as well as processing the API data and for UI
 *  purposes.
 */

namespace WinWeather
{
    /*
     * 
     * public class WeatherProcessor
     * 
     * Summary of the WeatherProcessor class
     * 
     */
    public class IncrementTracker
    {
        private int dayIncrement = 0;

        /*
         * 
         */

        public void changeDayIncrement(bool increment = false, bool decrement = false)  // Uses optional arguments to improve readability, both in the method and in the method calls.
        {
            if (increment)
            {
                dayIncrement++;
            }
            else if (decrement)
            {
                dayIncrement--;
            }
        }
        public int GetCurrentDayIncrement()
        {
            return dayIncrement;
        }
    }
}
