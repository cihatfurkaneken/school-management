using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Core.Entities;

namespace WebOBS.Entity
{
    public class DersOgrenci : IEntity
    {
        public int kayitNo { get; set; }
        public int ogrenciId { get; set; }
        public int dersNotu { get; set; }
        public int devamsizlik { get; set; }
        public int dersId { get; set; }
    }
}
