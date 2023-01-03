using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        // Views/Item/Index.cshtml
        public ActionResult Index()
        {
            return View();
        }

        // web 表示
        // Views/Item/ItemDetail.cshtml
        public ActionResult ItemDetail()
        {
            var info = new ActionItem();

            return View(info);
        }

        // web 表示
        // Views/Item/ItemEdit.cshtml
        public ActionResult ItemEdit()
        {
            var info = new ActionItem();

            return View(info);
        }
        // webからのアクション
        // Views/Item/ItemEdit.cshtml
        [HttpPost]
        public ActionResult ItemEdit([Bind(Include = "Name,Age,Sex,Add")] ActionItem aci)
        {
            var info = new ActionItem();

            info.Add = aci.Add;
            info.Name = aci.Name;
            info.Age = aci.Age;
            info.Sex = aci.Sex;

            return RedirectToAction("Index");

        }

        // web 表示
        // Views/Item/Create.cshtml
        public ActionResult Create()
        {
            var info = new ActionItem();

            info.Name = " ";
            info.Age = 0;
            info.Sex = " ";
            info.Add = " ";

            return View(info);
        }
        // webからアクション
        // Views/Item/Create.cshtml
        [HttpPost]
        public ActionResult Create([Bind(Include = "Name,Age,Sex,Add")] ActionItem aci)
        {
            var info = new ActionItem(aci.Name,aci.Age,aci.Sex,aci.Add);

            return RedirectToAction("Index");
        }

    }
}