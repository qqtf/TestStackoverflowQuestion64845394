using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Entities
{
	public class A_State
	{
		[Key]
		public int State_ID { get; set; }
		public string State_Name { get; set; }
	}
}
