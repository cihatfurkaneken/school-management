using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebOBS.Business.Abstract;
using WebOBS.DataAccess.Abstract;
using WebOBS.Entity;

namespace WebOBS.Business.Concrete.Managers
{
    public class DersManager : IDersService
    {
        IDersDAL _dersdal;
        
        public DersManager(IDersDAL ogrenciDal)
        {
            _dersdal = ogrenciDal;
        }

        public Ders Add(Ders ders)
        {
            return _dersdal.Add(ders);
        }

        public async Task<Ders> AddAsync(Ders ders)
        {
            return await _dersdal.AddAsync(ders);
        }

        public void Delete(Ders ders)
        {
            _dersdal.Delete(ders);
        }

        public Ders GetById(int id)
        {
            return _dersdal.Get(d => d.dersId == id);
        }

        public List<Ders> GetList()
        {
            return _dersdal.GetAll();
        }

        public Ders Update(Ders ders)
        {
            return _dersdal.Update(ders);
        }

        public async Task<Ders> UpdateAsync(Ders ders)
        {
            return await _dersdal.UpdateAsync(ders);
        }
    }
}
