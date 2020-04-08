namespace adapter
{
    //Классом-адаптером является IncomeDataAdapter.
    using IIncomeData = adapter.Solution.IIncomeData;

	public class IncomeData : IIncomeData
	{

		internal string countryCode, company, contactFirstName, contactLastName;
		internal int countryPhoneCode, phoneNumber;

		public IncomeData(string countryCode, string company, string contactFirstName, string contactLastName, int countryPhoneCode, int phoneNumber)
		{
			this.countryCode = countryCode;
			this.company = company;
			this.contactFirstName = contactFirstName;
			this.contactLastName = contactLastName;

			this.countryPhoneCode = countryPhoneCode;
			this.phoneNumber = phoneNumber;
		}

		public virtual string CountryCode
		{
			get
			{
				return this.countryCode;
			}
		}

		public virtual string Company
		{
			get
			{
				return this.company;
			}
		}

		public virtual string ContactFirstName
		{
			get
			{
				return this.contactFirstName;
			}
		}

		public virtual string ContactLastName
		{
			get
			{
				return this.contactLastName;
			}
		}

		public virtual int CountryPhoneCode
		{
			get
			{
				return countryPhoneCode;
			}
		}

		public virtual int PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
		}

		public override string ToString()
		{
			return this.countryCode + ", " + this.company + ", " + this.contactFirstName + ", " + this.contactLastName + ", " + this.countryPhoneCode + ", " + this.phoneNumber;
		}
	}

}