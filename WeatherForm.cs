using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherForecast
{
    public partial class WeatherForm : Form
    {
        private const string UrlTemplate = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{0}/{1}/{2}?unitGroup=metric&key={3}&lang=ua&contentType=json";
        private const string ApiKey = "XAW4E7XSTDNGQNP6GXBD7UK2Y";
        private string _lastJson;
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            List<City> list = new List<City>();
            {
                
                list.Add(new City("vinnytsia","Вінниця"));
                list.Add(new City("horlivka","Горлівка"));
                list.Add(new City("dnipro","Дніпро"));
                list.Add(new City("donetsk","Донецьк"));
                list.Add(new City("zhytomyr","Житомир"));
                list.Add(new City("zaporizhzhia","Запоріжжя"));
                list.Add(new City("ivanofrankivsk","Івано-Франківськ"));
                list.Add(new City("kamyanske","Кам'янське"));
                list.Add(new City("kyiv","Київ"));
                list.Add(new City("kryvyirih","Кривий Ріг"));
                list.Add(new City("kropyvnytskyi","Кропивницький"));
                list.Add(new City("luhansk","Луганськ"));
                list.Add(new City("lutsk","Луцьк"));
                list.Add(new City("%D0%BB%D1%8C%D0%B2%D1%96%D0%B2", "Львів"));
                list.Add(new City("makiyivka","Макіївка"));
                list.Add(new City("mariupol","Маріуполь"));
                list.Add(new City("mykolayiv","Миколаїв"));
                list.Add(new City("odesa","Одеса"));
                list.Add(new City("poltava","Полтава"));
                list.Add(new City("rivne","Рівне"));
                list.Add(new City("sevastopol","Севастополь"));
                list.Add(new City("simferopol","Сімферополь"));
                list.Add(new City("%D1%81%D1%83%D0%BC%D1%81%D1%8C%D0%BA%D0%B0", "Суми"));
                list.Add(new City("ternopil","Тернопіль"));
                list.Add(new City("kharkiv","Харків"));
                list.Add(new City("kherson","Херсон"));
                list.Add(new City("khmelnitskyi","Хмельницький"));
                list.Add(new City("cherkasy","Черкаси"));
                list.Add(new City("chernivtsi","Чернівці"));
                list.Add(new City("chernihiv","Чернігів"));

                comboBoxCity.DataSource = list;
                comboBoxCity.ValueMember = "ID";
                comboBoxCity.DisplayMember = "Name";
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var city = comboBoxCity.SelectedValue;
            var dateFrom = DateTime.Today.ToString("yyyy-MM-dd");
            var period = radioButtonToday.Checked ? 0 : radioButton7Days.Checked ? 6 : radioButton14Days.Checked ? 13 : throw new InvalidOperationException("Unknown forecast period");
            var dateTo = DateTime.Today.AddDays(period).ToString("yyyy-MM-dd");

            var url = String.Format(UrlTemplate, city, dateFrom, dateTo, ApiKey);
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, url);
            var httpResponse = await httpClient.SendAsync(httpRequest);
            httpResponse.EnsureSuccessStatusCode();
            var httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
            _lastJson = httpResponseBody;

            dynamic weatherForecastJson = JsonConvert.DeserializeObject(httpResponseBody);
            string weatherForecast = String.Empty;
            foreach (var day in weatherForecastJson.days)
            {
                DayForecast dayForecast = new DayForecast(
                    DateTime.Parse((string)day.datetime),
                    (string)day.description,
                    double.Parse((string)day.tempmax, CultureInfo.InvariantCulture),
                    double.Parse((string)day.tempmin, CultureInfo.InvariantCulture)
                );

                weatherForecast += dayForecast;
            }

            textBoxForecast.Text = weatherForecast;
            textBoxForecast.ScrollBars = ScrollBars.Vertical;
        }

        private void buttonSaveAsText_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = (comboBoxCity.SelectedItem as City).Name + " " + DateTime.Today.ToString("d") + ".txt";
                var filePath = Path.Combine(folderBrowserDialog.SelectedPath, fileName);
                File.WriteAllText(filePath, textBoxForecast.Text);
            }
        }

        private void buttonSaveAsJson_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = (comboBoxCity.SelectedItem as City).Name + " " + DateTime.Today.ToString("d") + ".json";
                var filePath = Path.Combine(folderBrowserDialog.SelectedPath, fileName);
                File.WriteAllText(filePath, _lastJson);
            }
        }
    }
}
