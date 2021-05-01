using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Core.DataAccess;
using WebOBS.Entity;

namespace WebOBS.DataAccess.Abstract
{
    public interface IDersOgrenciDAL : IEntityRepository<DersOgrenci>
    {
        List<DersOgrenciComplex> Dersogrencibirlesim();
    }
}
