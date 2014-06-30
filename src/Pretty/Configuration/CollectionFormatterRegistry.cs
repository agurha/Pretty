using Pretty.Localisation.CollectionFormatters;

namespace Pretty.Configuration
{
    internal class CollectionFormatterRegistry : LocaliserRegistry<ICollectionFormatter>
    {
        public CollectionFormatterRegistry()
            : base(new DefaultCollectionFormatter())
        {
            Register("en", new EnglishCollectionFormatter());
        }
    }
}
