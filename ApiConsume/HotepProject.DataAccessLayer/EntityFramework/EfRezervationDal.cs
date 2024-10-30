﻿using HotelProject.DataAccessLayer.Abstacrt;
using HotelProject.DataAccessLayer.Concrate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfRezervationDal : GenericRepository<Rezervation>, IRezervationDal
	{
		public EfRezervationDal(Context context) : base(context)
		{

		}
	}
}