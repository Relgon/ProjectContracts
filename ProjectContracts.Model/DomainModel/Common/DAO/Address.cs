namespace ProjectContracts.Model {
	public class Address : BaseModel {

		public virtual string Country { get; set; }
		public virtual string AdministrativeArea { get; set; }
		public virtual string City { get; set; }
		public virtual string Apartment { get; set; }
		public virtual string PostalCode { get; set; }
	}
}
