using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebApi.Dtos.ServiceDto
{
	public class CreateServiceDto
	{
		[Required(ErrorMessage ="İcon linki zorunludur.")]
		public string Icon { get; set; }

		[Required(ErrorMessage = "Hizmet başlığı giriniz.")]
		public string Title { get; set; }

		public string Description { get; set; }
	}
}
