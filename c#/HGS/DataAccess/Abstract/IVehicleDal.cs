﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Abstract;

namespace DataAccess.Abstract
{
    public interface IVehicleDal : IEntityRepository<IVehicle>
    {

    }
}
