﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
	public class Reservation
	{
		public Guid Guid { get; set; }
		public Room Room { get; set; }
		public Customer Customer { get; set; }
		public TimePeriod TimePeriod { get; set; }

		public Reservation()
		{
			
		}

		public Reservation(Room room, Customer customer, TimePeriod timePeriod)
		{
			Guid = Guid.NewGuid();
			Room = room;
			Customer = customer;
			TimePeriod = timePeriod;
		}
	}
}
