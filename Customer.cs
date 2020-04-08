namespace adapter
{   // adaptee class
	using ICustomer = adapter.Solution.ICustomer;

	public class Customer : ICustomer
	{

		internal string companyName, countryName;

		public Customer(string companyName, string countryName)
		{
			this.companyName = companyName;
			this.countryName = countryName;
		}

		public virtual string CompanyName
		{
			get
			{
				return this.companyName;
			}
		}

		public virtual string CountryName
		{
			get
			{
				return this.countryName;
			}
		}

		public override string ToString()
		{
			return this.companyName + ", " + this.countryName;
		}
	}

}