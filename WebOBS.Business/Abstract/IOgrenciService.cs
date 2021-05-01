using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebOBS.Entity;

namespace WebOBS.Business.Abstract
{
    public interface IOgrenciService
    {
        Ogrenci Add(Ogrenci ogrenci);
        Task<Ogrenci> AddAsync(Ogrenci ogrenci);
        Ogrenci Update(Ogrenci ogrenci);
        Task<Ogrenci> UpdateAsync(Ogrenci ogrenci);
        void Delete(Ogrenci ogrenci);
        Ogrenci GetById(int id);
        List<Ogrenci> GetList();
    }
}
