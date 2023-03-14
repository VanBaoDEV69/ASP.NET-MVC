using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcGGMobile.Models;

namespace mvcGGMobile.Controllers
{
    public class GGMobileController : Controller
    {
        //database
        dbGGMobileDataContext data = new dbGGMobileDataContext();

        private List<SanPham> LaySanphammoi (int count)
        {
            return data.SanPhames.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        }
        // GET: GGMobile
        public ActionResult Index()
        {
            var sanphammoi = LaySanphammoi(5);
            return View(sanphammoi);
        }
    }
}