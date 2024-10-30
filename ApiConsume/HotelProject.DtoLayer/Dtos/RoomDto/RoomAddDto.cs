using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
	public class RoomAddDto
	{
		[Required(ErrorMessage ="Oda numarası giriniz.")]
		public string RoomNumber { get; set; }

		public string RoomCoverImage { get; set; }

		[Required(ErrorMessage = "Oda için fiyat bilgisi giriniz.")]
		public int Price { get; set; }

		public string Title { get; set; }

		[Required(ErrorMessage = "Oda için yatak sayısı giriniz.")]
		public string BadCount { get; set; }

		public string BathCount { get; set; }

		public string Wifi { get; set; }

		public string Description { get; set; }
	}
}
