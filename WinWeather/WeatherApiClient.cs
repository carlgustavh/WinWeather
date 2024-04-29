using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using WinWeather.Properties;

namespace WinWeather
{
    public static class WeatherApiClient
    {
        public static async Task<ApiResponseHandler> GetWeatherFromApi(Day day)
        {
            string baseUrl = "http://api.weatherapi.com/v1";
            string apiMethod = day.IsToday() ? "/current.json" : "/forecast.json";
            string key = "KEY";
            string location = day.city;
            string forecastAmountDays = day.dayIncrement.ToString();

            string requestUrl = day.IsToday() ? $"{baseUrl}{apiMethod}?key={key}&q={location}&aqi=no"
                : $"{baseUrl}{apiMethod}?key={key}&q={location}&days={forecastAmountDays}&aqi=no&alerts=no";

            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    string responseData = await response.Content.ReadAsStringAsync();

                    ApiResponseHandler apiResponseHandler = new ApiResponseHandler(responseData, day);

                    Clipboard.SetText(responseData);

                    return (apiResponseHandler);
                }
                else
                {
                    MessageBox.Show($"Failed to fetch weather data. Status code: {response.StatusCode}. Data is defaulted to London, City of London, Greater London, United Kingdom. Local time: 2024-Apr-24 22:45");
                    ApiResponseHandler fallbackResponse = GetFallbackResponse();
                    return (fallbackResponse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                throw;
            }

            ApiResponseHandler GetFallbackResponse()
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string resourceName = "WinWeather.FallbackApiData.txt";

                using Stream? stream = assembly.GetManifestResourceStream(resourceName);
                if (stream == null)
                {
                    MessageBox.Show($"Exception: File Not Found. Resource '{resourceName}' not found.");
                    throw new FileNotFoundException($"Resource '{resourceName}' not found.");
                }

                using StreamReader reader = new StreamReader(stream);
                string fallbackApiData = reader.ReadToEnd();

                return new ApiResponseHandler(fallbackApiData, day);
            }
        }
    }
}
