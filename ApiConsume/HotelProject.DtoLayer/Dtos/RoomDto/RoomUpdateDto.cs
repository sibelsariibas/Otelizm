using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
	public class RoomUpdateDto
	{

		public int RoomID { get; set; }

		[Required(ErrorMessage = "Oda numarası giriniz.")]
		public string RoomNumber { get; set; }

		public string RoomCoverImage { get; set; }

		[Required(ErrorMessage = "Oda için fiyat bilgisi giriniz.")]
		public int Price { get; set; }

		[Required(ErrorMessage = "Başlık giriniz.")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Yatak sayısı giriniz.")]
		public string BadCount { get; set; }

		[Required(ErrorMessage = "Banyo sayısı giriniz.")]
		public string BathCount { get; set; }

		public string Wifi { get; set; }

		public string Description { get; set; }
	}
}
