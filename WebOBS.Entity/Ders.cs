using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Core.Entities;

namespace WebOBS.Entity
{
    public class Ders : IEntity
    {
        public int dersId { get; set; }
        public int dersNo { get; set; }
        public string dersAdi { get; set; }
        public int dersKredi { get; set; }
        public string ogretmen { get; set; }
    }
}
