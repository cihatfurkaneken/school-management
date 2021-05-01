using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Core.DataAccess.EntityFrameworkCore;
using WebOBS.DataAccess.Abstract;
using WebOBS.Entity;
using System.Linq;

namespace WebOBS.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfDersOgrenciDAL : EfEntityRepositoryBase<DersOgrenci, WebOBSDbContext>, IDersOgrenciDAL
    {
        public List<DersOgrenciComplex> Dersogrencibirlesim()
        {
            using (var _context = new WebOBSDbContext())
            {
                var result = from p in _context.DersOgrenci
                             join c in _context.Ogrenci on p.ogrenciId equals c.ogrId
                             join d in _context.Ders on p.dersId equals d.dersId
                             select new DersOgrenciComplex
                             {
                                 DersAdi = d.dersAdi,
                                 dersNot = p.dersNotu,
                                 kayitNo = p.kayitNo,
                                 devamsizlik = p.devamsizlik,
                                 OgrenciAdi = c.ogrAdi
                             };
                return result.ToList();
            }
        }
    }
}
