using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOBS.Entity;
namespace WebObs.MVC.Models
{
    public class DersOgrenciModel
    {
        public DersOgrenci dersogrenci { get; set; }
        public List<DersOgrenciComplex> dersogrenciler { get; set; }
        public List<SelectListItem> ogrenciler { get; set; }
    }
}
