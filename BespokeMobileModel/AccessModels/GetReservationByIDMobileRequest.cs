﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BespokeMobileModel.AccessModels
{
    [Serializable]
    public class GetReservationByIDMobileRequest
    {
        public int? ReservationID { get; set; }
    }
}
