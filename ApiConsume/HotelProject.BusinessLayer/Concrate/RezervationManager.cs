using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstacrt;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrate
{
	public class RezervationManager : IRezervationService
	{
		private readonly IRezervationDal _rezervationDal;
		public RezervationManager(IRezervationDal rezervationDal)
		{
			_rezervationDal = rezervationDal;
		}

		public void TDelete(Rezervation t)
		{
			_rezervationDal.Delete(t);
		}

		public Rezervation TGetById(int id)
		{
			return _rezervationDal.GetById(id);
		}

		public List<Rezervation> TGetList()
		{
			return _rezervationDal.GetList();
		}

		public void TInsert(Rezervation t)
		{
			_rezervationDal.Insert(t);
		}

		public void TUpdate(Rezervation t)
		{
			_rezervationDal.Update(t);
		}
	}
}
