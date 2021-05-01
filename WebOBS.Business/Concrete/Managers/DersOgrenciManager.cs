using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebOBS.Business.Abstract;
using WebOBS.DataAccess.Abstract;
using WebOBS.Entity;

namespace WebOBS.Business.Concrete.Managers
{
    public class DersOgrenciManager : IDersOgrenciService
    {
        IDersOgrenciDAL _dersogrenciDal;
        public DersOgrenciManager(IDersOgrenciDAL dersOgrenciDAL)
        {
            _dersogrenciDal = dersOgrenciDAL;
        }
        public DersOgrenci Add(DersOgrenci dersOgrenci)
        {
            return _dersogrenciDal.Add(dersOgrenci);
        }

        public async Task<DersOgrenci> AddAsync(DersOgrenci dersOgrenci)
        {
            return await _dersogrenciDal.AddAsync(dersOgrenci);
        }

        public void Delete(DersOgrenci dersOgrenci)
        {
            _dersogrenciDal.Delete(dersOgrenci);
        }

        public DersOgrenci GetById(int id)
        {
            return _dersogrenciDal.Get(d => d.kayitNo == id);
        }

        public List<DersOgrenci> GetList()
        {
            return _dersogrenciDal.GetAll();
        }

        public List<DersOgrenci> GetListByOgrenciId(int ogrId)
        {
            return _dersogrenciDal.GetAll(d => d.ogrenciId == ogrId);
        }

        public List<DersOgrenciComplex> Dersogrencibirlesim()
        {
            return _dersogrenciDal.Dersogrencibirlesim();
        }

        public DersOgrenci Update(DersOgrenci dersOgrenci)
        {
            return _dersogrenciDal.Update(dersOgrenci);
        }

        public async Task<DersOgrenci> UpdateAsync(DersOgrenci dersOgrenci)
        {
            return await _dersogrenciDal.UpdateAsync(dersOgrenci);
        }
    }
}
