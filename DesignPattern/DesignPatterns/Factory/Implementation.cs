namespace Factory
{
    public abstract class DiscountService
    {
         public abstract int DiscountPercentage { get; }
         public override string ToString() => GetType().Name;
    }

    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "PL":
                        return 99;
                    default:
                        return 5;
                }
            }
        }
    }

    public class CodeDiscountService : DiscountService
    {
        public override int DiscountPercentage
        {
            get => 20;
        }
    }

    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    public class CodeDiscountFactory : DiscountFactory
    {
        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService();
        }
    }
    
    public class CountryDiscountFactory : DiscountFactory
    {
        public string _code { get; set; }

        public CountryDiscountFactory(string code)
        {
            _code = code;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_code);
        }
    }
}