using System.Reflection;

namespace WinWeather
{
    public partial class HomeForm : Form
    {
        IncrementTracker incrementTracker;
        ApplicationController applicationController;

        public HomeForm(IncrementTracker incrementTracker, ApplicationController applicationController)
        {
            InitializeComponent();
            ClearData();
            this.incrementTracker = incrementTracker;
            this.applicationController = applicationController;
        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            if (cityInput.Text == "")
            {
                MessageBox.Show("Please enter a city name");
                return;
            }

            ApiResponseHandler apiResponseHandler = await applicationController.Load(cityInput.Text);
            Day day = applicationController.GetDay();
            
            SetData(apiResponseHandler, day);
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            if (incrementTracker.GetCurrentDayIncrement() >= 3)
            {
                MessageBox.Show("Maxium forecast is 3 days into the future!");
                return;
            }
            incrementTracker.changeDayIncrement(increment: true);
            loadButton_Click(sender, e);
        }

        private void previousDayButton_Click(object sender, EventArgs e)
        {
            if (incrementTracker.GetCurrentDayIncrement() <= 0)
            {
                MessageBox.Show("Unable to get past weather data");
                return;
            }
            incrementTracker.changeDayIncrement(decrement: true);
            loadButton_Click(sender, e);
        }
        private void SetData(ApiResponseHandler apiResponseHandler, Day day)
        {
            if (apiResponseHandler.isToday)
            {
                temperatureTextC.Text = $"{apiResponseHandler.temperatureC}°C";
                disclaimerLabel.Visible = false;
                groupBox.Text = $"Now ({day.uiDateString})";
            }
            else
            {
                temperatureTextC.Text = $"{apiResponseHandler.temperatureC}°C*";
                disclaimerLabel.Visible = true;
                groupBox.Text = $"{day.uiDateString}";
            }
            conditionText.Text = apiResponseHandler.conditionText;
            try
            {
                conditionIcon.Load(apiResponseHandler.conditionIconUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ClearData()
        {
            groupBox.Text = "Today? Tomorrow? Who knows!";
            temperatureTextC.Text = "??°C";
            disclaimerLabel.Visible = false;
            conditionText.Text = "Sunny? Rainy? I don't know...";
            conditionIcon.Image = null;
        }
    }
}