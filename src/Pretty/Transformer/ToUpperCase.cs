namespace Pretty
{
    class ToUpperCase : IStringTransformer
    {
        public string Transform(string input)
        {
            return input.ToUpper();
        }
    }
}