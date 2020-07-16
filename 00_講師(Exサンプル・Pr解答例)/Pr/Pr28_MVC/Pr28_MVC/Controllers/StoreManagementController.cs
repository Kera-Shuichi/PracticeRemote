using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pr28_MVC.Controllers
{
    public class StoreManagementController : Controller
    {
        // GET: StoreManagement
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Insert()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Result(string txtId, string txtCustomerName, string txtContactName, string txtPhoneNumber)
        {
            // モデルのインスタンス化
            var model = new Models.StoreManagement();

            // INSERT処理実行
            string message = model.InsertCustomer(txtId, txtCustomerName, txtContactName, txtPhoneNumber);

            // 実行結果をViewDataに格納
            ViewData["Message"] = message;

            return View();
        }
    }
}