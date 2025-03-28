using System;
namespace TestETL.Commons.Models
{
	public class UserDateIdentity:BaseIdentity
	{
		public UserDateIdentity()
		{ }
            public DateTimeOffset Created { get; set; }
            public DateTimeOffset LastEdited { get; set; }
            public DateTimeOffset? Deleted { get; set; }
	}
}

