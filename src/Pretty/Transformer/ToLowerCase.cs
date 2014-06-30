using System.Globalization;

namespace Pretty
{
    class ToLowerCase : IStringTransformer
    {
        public string Transform(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToLower(input);
        }
    }
}