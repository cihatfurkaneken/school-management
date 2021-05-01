using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebOBS.Entity;

namespace WebOBS.Business.Abstract
{
    public interface IDersOgrenciService
    {
        DersOgrenci Add(DersOgrenci dersOgrenci);
        Task<DersOgrenci> AddAsync(DersOgrenci dersOgrenci);
        DersOgrenci Update(DersOgrenci dersOgrenci);
        Task<DersOgrenci> UpdateAsync(DersOgrenci dersOgrenci);
        void Delete(DersOgrenci dersOgrenci);
        DersOgrenci GetById(int id);
        List<DersOgrenci> GetList();
        List<DersOgrenci> GetListByOgrenciId(int ogrId);
        List<DersOgrenciComplex> Dersogrencibirlesim();
    }
}
