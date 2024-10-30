using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstacrt;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrate
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribedal;   
        public SubscribeManager(ISubscribeDal subscribedal)
        {
            _subscribedal = subscribedal;
        }
    
        public void TDelete(Subscribe t)
        {
            _subscribedal.Delete(t);
        }

        public Subscribe TGetById(int id)
        {
            return _subscribedal.GetById(id);   
        }

        public List<Subscribe> TGetList()
        {
            return _subscribedal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _subscribedal.Insert(t);    
        }

        public void TUpdate(Subscribe t)
        {
            _subscribedal.Update(t);    
        }
    }
}
