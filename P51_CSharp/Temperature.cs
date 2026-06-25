namespace P51_CSharp
{
    public class Temperature
    {
        float temperature;

        public Temperature(float temp)
        {
            temperature = temp;
        }

        public float Celsius
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public float Kelvin
        {
            get { return temperature + 273.15f; }
            set { temperature = value - 273.15f; }
        }

        public float Fahrenheit
        {
            get { return temperature * 1.8f + 32f; }
            set { temperature = (value - 32f) / 1.8f; }
        }

    }
}