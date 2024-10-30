using HotelProject.DataAccessLayer.Abstacrt;
using HotelProject.DataAccessLayer.Concrate;
using HotelProject.EntityLayer.Concrate;
using HotelProject.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(Context context) : base(context)
    {

    }
}
}
