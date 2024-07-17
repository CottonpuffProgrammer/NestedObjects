using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace NestedObjects
{
	/// <summary>
	/// Represents a college advisor
	/// </summary>
	public class Advisor
	{
		/// <summary>
		/// The legal first and last name of the advisor
		/// </summary>
		public string FullName { get; set; }

		/// <summary>
		/// The work email of the advisor
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// The building and room number of the
		/// office of the advisor
		/// </summary>
		public string OfficeLocation { get; set; }

	}
}
