using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOBS.Business.Abstract;
using WebObs.MVC.Models;
using WebOBS.Entity;
using Microsoft.AspNetCore.Authorization;

namespace WebObs.MVC.Controllers
{
    [Authorize]// Giriş yapılmaz ise sayfalara ulaşılamaz özelliği ekliyor
    public class OgrenciController : Controller
    {
        IOgrenciService _ogrenciService;
        public OgrenciController(IOgrenciService ogrenciService)
        {
            _ogrenciService = ogrenciService;
        }
        public IActionResult GetOgrenciler()
        {
            var ogrenciViewModel = new OgrenciViewModel
            {
                ogrenciler = _ogrenciService.GetList()

            };
            return View(ogrenciViewModel);
        }
        public IActionResult Add(OgrenciViewModel ogrenciViewModel)
        {
            if (ModelState.IsValid)
            {
                var ogrenciEkle = new Ogrenci
                {
                    ogrAdi = ogrenciViewModel.ogrenci.ogrAdi,
                    ogrNo = ogrenciViewModel.ogrenci.ogrNo,
                    eposta = ogrenciViewModel.ogrenci.eposta                    
                };
                try
                {
                    _ogrenciService.Add(ogrenciEkle);
                    return RedirectToAction("GetOgrenciler");
                }
                catch (Exception)
                {

                }
            }
            return RedirectToAction("GetOgrenciler");
        }
        public JsonResult Edit(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }
            var ogrenci = _ogrenciService.GetById(id);
            if (ogrenci == null)
            {
                return Json(0);
            }
            return Json(ogrenci);
        }
        [HttpPost]
        public IActionResult Edit(OgrenciViewModel ogrenciViewModel)
        {
            if (ModelState.IsValid)
            {
                var ogrencikontrol = _ogrenciService.GetById(ogrenciViewModel.ogrenci.ogrId);
                if (ogrencikontrol == null)
                {
                    return RedirectToAction("GetOgrenciler");
                }
                try
                {
                    var ogrenciEkle = new Ogrenci
                    {
                        ogrAdi = ogrenciViewModel.ogrenci.ogrAdi,
                        ogrNo = ogrenciViewModel.ogrenci.ogrNo,
                        ogrId = ogrencikontrol.ogrId,                        
                        eposta = ogrenciViewModel.ogrenci.eposta
                    };
                    _ogrenciService.Update(ogrenciEkle);
                    return RedirectToAction("GetOgrenciler");
                }
                catch (Exception)
                {
                    return RedirectToAction("GetOgrenciler");
                }
            }
            return RedirectToAction("GetOgrenciler");
        }
        
        public JsonResult Delete(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }
            var ogrencikontrol = _ogrenciService.GetById(id);
            if (ogrencikontrol == null)
            {
                return Json(0);
            }
            try
            {
                _ogrenciService.Delete(ogrencikontrol);
                return Json(1);
                
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
