namespace WinWeather
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            IncrementTracker incrementTracker = new IncrementTracker();
            ApplicationController applicationController = new ApplicationController(incrementTracker);

            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm(incrementTracker, applicationController));
        }
    }

    public class ApplicationController
    {
        Day day;
        IncrementTracker incrementTracker;

        public ApplicationController(IncrementTracker incrementTracker)
        {
            this.incrementTracker = incrementTracker;
            day = new Day(incrementTracker, "London");  // Placeholder.
        }

        public async Task<ApiResponseHandler> Load(string city)
        {
            day = new Day(incrementTracker, city);
            return await WeatherApiClient.GetWeatherFromApi(day);
        }

        public Day GetDay()
        {
            return day;
        }
    }
}