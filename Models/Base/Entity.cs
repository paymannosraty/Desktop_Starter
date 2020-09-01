namespace Models.Base
{
	public abstract class Entity : object
	{
		public Entity() : base()
		{
			Id =
				System.Guid.NewGuid();

			InsertDateTime = System.DateTime.Now;
		}

		// **********
		/// <summary>
		/// شماره منحصر به فرد
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public System.Guid Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان درج اطلاعات
		/// </summary>		
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public System.DateTime InsertDateTime { get; set; }
		// **********
	}
}
