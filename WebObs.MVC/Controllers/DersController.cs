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
    [Authorize] // Giriş yapılmaz ise sayfalara ulaşılamaz özelliği ekliyor
    public class DersController : Controller
    {
        
        IDersService _dersService;
        public DersController(IDersService dersService)
        {
            _dersService = dersService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetDersler()
        {
            var dersViewModel = new DersViewModel
            {
                dersler = _dersService.GetList()
            };
            return View(dersViewModel);
        }
        public IActionResult Add(DersViewModel dersViewModel)
        {
            if (ModelState.IsValid)
            {
                var dersEkle = new Ders
                {
                    dersAdi = dersViewModel.ders.dersAdi,
                    dersNo = dersViewModel.ders.dersNo,
                    dersKredi = dersViewModel.ders.dersKredi,
                    ogretmen = dersViewModel.ders.ogretmen
                };
                try
                {
                    _dersService.Add(dersEkle);
                    return RedirectToAction("GetDersler");
                }
                catch (Exception)
                {

                }
            }
            return RedirectToAction("GetDersler");
        }
        public JsonResult Edit(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }
            var category = _dersService.GetById(id);
            if (category == null)
            {
                return Json(0);
            }
            return Json(category);
        }
        [HttpPost]
        public IActionResult Edit(DersViewModel dersViewModel)
        {
            if (ModelState.IsValid)
            {
                var derskontrol = _dersService.GetById(dersViewModel.ders.dersId);
                if (derskontrol == null)
                {
                    return RedirectToAction("GetDersler");
                }
                try
                {
                    var dersduzenle = new Ders
                    {
                        dersAdi = dersViewModel.ders.dersAdi,
                        dersNo = dersViewModel.ders.dersNo,
                        dersKredi = dersViewModel.ders.dersKredi,
                        ogretmen = dersViewModel.ders.ogretmen,
                        dersId = derskontrol.dersId
                       
                    };
                    _dersService.Update(dersduzenle);
                    return RedirectToAction("GetDersler");
                }
                catch (Exception)
                {
                    return RedirectToAction("GetDersler");
                }
            }
            return RedirectToAction("GetDersler");
        }
        public JsonResult Delete(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }
            var derskontrol = _dersService.GetById(id);
            if (derskontrol == null)
            {
                return Json(0);
            }
            try
            {
                _dersService.Delete(derskontrol);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
