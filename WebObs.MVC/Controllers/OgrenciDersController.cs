using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOBS.Business.Abstract;
using WebObs.MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebOBS.Entity;
using Microsoft.AspNetCore.Authorization;

namespace WebObs.MVC.Controllers
{
    [Authorize] // Giriş yapılmaz ise sayfalara ulaşılamaz özelliği ekliyor
    public class OgrenciDersController : Controller
    {
        IDersOgrenciService _ogrenciService;
        IOgrenciService _ogrService;
        public OgrenciDersController(IDersOgrenciService ogrenciService, IOgrenciService ogrService)
        {
            _ogrenciService = ogrenciService;
            _ogrService = ogrService;
        }
        public IActionResult GetOgrenciDers()
        {

            var OgrenciViewModel = new DersOgrenciModel
            {
                dersogrenciler = _ogrenciService.Dersogrencibirlesim()
               
            };
                return View(OgrenciViewModel);            
            
        }
        
        public IActionResult LoadOgrenci(int id)
        {
            if (id > 0) { 
            var ogrencii = _ogrenciService.GetById(id);           
            var productViewModel = new DersOgrenciModel
            {
                dersogrenci = ogrencii                
               
            };
            return View(productViewModel);
        }
            return RedirectToAction("GetOgrenciDers");
    }

    }
}
