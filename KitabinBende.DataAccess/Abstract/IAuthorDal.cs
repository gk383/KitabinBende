﻿using KitabinBende.Core.DataAccess;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.DataAccess.Abstract
{
    public interface IAuthorDal:IEntityRepository<Author>
    {
        //Custom Operations
    }
}
