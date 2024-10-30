namespace HotelProject.WebApi.Dtos.AboutDto
{
    public class ResultAboutDto
    {
        public int AboutId { get; set; }
        public string Header { get; set; }

        public string Description { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
