using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOBS.Entity;

namespace WebObs.MVC.Models
{
    public class OgrenciViewModel
    {
        public Ogrenci ogrenci { get; set; }
        public List<Ogrenci> ogrenciler { get; set; }
    }
}
