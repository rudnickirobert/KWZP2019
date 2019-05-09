
namespace System
{
    public class BoolFormatter : ICustomFormatter, IFormatProvider
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            else
            {
                return null;
            }
        }
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            bool value = false;
            string argString = Convert.ToString(arg);
            switch (argString.Trim())
            {
                case "False":
                    {
                        value = false;
                        break;
                    }
                case "Nie":
                    {
                        value = false;
                        break;
                    }
                case "True":
                    {
                        value = true;
                        break;
                    }
                case "Tak":
                    {
                        value = true;
                        break;
                    }
            }
            switch (format ?? string.Empty)
            {
                case "YesNo":
                    {
                        return (value) ? "Yes" : "No";
                    }
                case "TakNie":
                    {
                        return (value) ? "Tak" : "Nie";
                    }
                default:
                    {
                        return value.ToString();
                    }
            }
        }
    }
}
