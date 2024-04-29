using System.Drawing.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace WinWeather
{
    public class ApiResponseHandler
    {
        public bool isToday;
        public Day day;

        private JsonDocument responseJsonDoc;
        private JsonElement responseJsonRoot;
        //  CURRENT //
        private JsonElement currentResponseDay;
        private JsonElement currentResponseCondition;
        //  FORECAST //
        private JsonElement forecastResponseDay;
        private JsonElement forecastResponseCondition;


        public string temperatureC = "";
        public string conditionText = "";

        private readonly string conditionIconPropertyString = "";
        public string conditionIconUrl = "";

        public ApiResponseHandler(string responseData, Day day) {
            this.day = day;
            isToday = day.IsToday();

            responseJsonDoc = JsonDocument.Parse(responseData);
            responseJsonRoot = responseJsonDoc.RootElement;

            if (isToday)
            {
                currentResponseDay = responseJsonRoot.GetProperty("current");
                currentResponseCondition = currentResponseDay.GetProperty("condition");


                temperatureC = currentResponseDay.GetProperty("temp_c")
                .GetDecimal()
                .ToString();

                conditionText = currentResponseCondition.GetProperty("text")
                .GetString() ?? "";

                conditionIconPropertyString = currentResponseCondition.GetProperty("icon").GetString() ?? "";
            }
            else
            {
                forecastResponseDay = responseJsonRoot.GetProperty("forecast")
                    .GetProperty("forecastday")[day.incrementTracker.GetCurrentDayIncrement()-1]
                    .GetProperty("day");

                forecastResponseCondition = forecastResponseDay.GetProperty("condition");

                temperatureC = forecastResponseDay.GetProperty("avgtemp_c")
                .GetDecimal()
                .ToString();

                conditionText = forecastResponseCondition.GetProperty("text")
                .GetString() ?? "";

                conditionIconPropertyString = forecastResponseCondition.GetProperty("icon").GetString() ?? "";
            }
            conditionIconUrl = $"https://{conditionIconPropertyString?[2..]}" ?? "";
        }
    }
}
