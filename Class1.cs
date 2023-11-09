namespace TempConvComp
{
    public class Class1
    {
        public List<double> CelciusToAll(double c)
        {
            List<double> result = new List<double>();
            result.Add(c * 0.8); //C to R
            result.Add(c * 1.8 + 32); // C to F
            result.Add(c + 273.15); //C to K
            return result;
        }

        public List<double> ReamurToAll(double r)
        {
            List<double> result = new List<double>();
            result.Add(r * 1.25); //R to C
            result.Add(r * 2.25 + 32); // R to F
            result.Add(r * 1.25 + 273.15); //R to K
            return result;
        }

        public List<double> FahrenheitToAll(double f)
        {
            List<double> result = new List<double>();
            result.Add((f-32) * 0.56); //F to C
            result.Add((f-32) * 0.44); // F to R
            result.Add((f+459.67) * 0.56); //F to K
            return result;
        }

        public List<double> KelvinToAll(double k)
        {
            List<double> result = new List<double>();
            result.Add(k - 273.15); //K to C
            result.Add((k - 273.15) * 0.8); // K to R
            result.Add(k * 1.8 - 459.67); //K to F
            return result;
        }

    }
}