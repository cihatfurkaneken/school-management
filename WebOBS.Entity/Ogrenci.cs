using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Core.Entities;

namespace WebOBS.Entity
{
    public class Ogrenci : IEntity
    {
        public int ogrId { get; set; }
        public string ogrAdi { get; set; }
        public int ogrNo { get; set; }        
        public string eposta { get; set; }
    }
}
