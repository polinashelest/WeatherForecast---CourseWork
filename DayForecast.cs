using System;

namespace WeatherForecast
{
    class DayForecast
    {
        public DateTime Date { get; }
        public string Conditions { get; }
        public double MaxTemperature { get; }
        public double MinTemperature { get; }

        

        public DayForecast(DateTime date, string conditions, double maxTemperature, double minTemperature)
        {
            Date = date;
            Conditions = conditions;
            MaxTemperature = maxTemperature;
            MinTemperature = minTemperature;
        }

        public override string ToString()
        {
            return $"Дата: {Date:d}" + Environment.NewLine +
                $"День тижня: {Date:dddd}" + Environment.NewLine +
                $"Погодні умови: {Conditions}" + Environment.NewLine +
                $"Максимальна температура: {MaxTemperature}" + Environment.NewLine +
                $"Мінімальна температура: {MinTemperature}" + Environment.NewLine + Environment.NewLine;
        }
    }
}
