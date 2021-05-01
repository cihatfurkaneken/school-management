using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOBS.Entity;

namespace WebObs.MVC.Models
{
    public class DersViewModel
    {
        public Ders ders { get; set; }
        public List<Ders> dersler { get; set; }
    }
}
