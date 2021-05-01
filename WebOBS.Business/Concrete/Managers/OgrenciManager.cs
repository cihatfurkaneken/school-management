using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebOBS.Business.Abstract;
using WebOBS.DataAccess.Abstract;
using WebOBS.Entity;

namespace WebOBS.Business.Concrete.Managers
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDAL _ogrenciDal;
        public OgrenciManager(IOgrenciDAL ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        public Ogrenci Add(Ogrenci ogrenci)
        {
            return _ogrenciDal.Add(ogrenci);
        }

        public async Task<Ogrenci> AddAsync(Ogrenci ogrenci)
        {
            return await _ogrenciDal.AddAsync(ogrenci);
        }

        public void Delete(Ogrenci ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
        }

        public Ogrenci GetById(int id)
        {
            return _ogrenciDal.Get(d => d.ogrId == id);
        }

        public List<Ogrenci> GetList()
        {
            return _ogrenciDal.GetAll();
        }

        public Ogrenci Update(Ogrenci ogrenci)
        {
            return _ogrenciDal.Update(ogrenci);
        }

        public async Task<Ogrenci> UpdateAsync(Ogrenci ogrenci)
        {
            return await _ogrenciDal.UpdateAsync(ogrenci);
        }
    }
}
