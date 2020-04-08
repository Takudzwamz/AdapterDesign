namespace adapter
{  //adaptee class
	using IContact = adapter.Solution.IContact;

	public class Contact : IContact
	{

		internal string name, phoneNumber;

		public Contact(string name, string phoneNumber)
		{
			this.name = name;
			this.phoneNumber = phoneNumber;
		}

		public virtual string Name
		{
			get
			{
				return this.name;
			}
		}

		public virtual string PhoneNumber
		{
			get
			{
				return this.phoneNumber;
			}
		}

		public override string ToString()
		{
			return this.name + ", " + this.phoneNumber;
		}
	}

}