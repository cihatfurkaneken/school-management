using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebOBS.Entity;

namespace WebOBS.Business.Abstract
{
    public interface IDersService
    {
        Ders Add(Ders ders);
        Task<Ders> AddAsync(Ders ders);
        Ders Update(Ders ders);
        Task<Ders> UpdateAsync(Ders ders);
        void Delete(Ders ders);
        Ders GetById(int id);
        List<Ders> GetList();
    }
}
