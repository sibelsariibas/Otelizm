using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebApi.Dtos.ServiceDto
{
	public class UpdateServiceDto
	{
		public int ServiceID { get; set; }
		[Required(ErrorMessage = "İcon linki zorunludur.")]
		public string Icon { get; set; }

		[Required(ErrorMessage = "Hizmet başlığı giriniz.")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Hizmet açıklaması giriniz.")]
		public string Description { get; set; }
	}
}
