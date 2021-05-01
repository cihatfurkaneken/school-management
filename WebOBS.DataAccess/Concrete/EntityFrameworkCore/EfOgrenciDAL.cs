using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Core.DataAccess.EntityFrameworkCore;
using WebOBS.DataAccess.Abstract;
using WebOBS.Entity;

namespace WebOBS.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfOgrenciDAL : EfEntityRepositoryBase<Ogrenci, WebOBSDbContext>, IOgrenciDAL
    {
    }
}
