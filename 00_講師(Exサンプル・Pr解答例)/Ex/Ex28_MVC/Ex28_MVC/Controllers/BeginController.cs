using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex28_MVC.Controllers
{
    // 「<コントローラ名>Controller」とみなされる。今回のコントローラ名は「Begin」となる。
    public class BeginController : Controller
    {
        // AcceptVerbs: 紐づくアクションがGETとPOSTどちらで呼ばれるかを指定できる。
        [AcceptVerbs(HttpVerbs.Get)]
        // アクションメソッド: ルーティングによってどのアクションメソッドが呼び出されるか決定する。
        public ActionResult View1()
        {
            return View();  // 「<ローカルホスト名>/<コントローラ名>/<アクション名>.cshtml」のViewを返す。
        }

        [AcceptVerbs(HttpVerbs.Post)]
        // 引数名と一致するnameを持つ要素が呼び出し元のView上に存在する場合、その要素のvalueを取得する。
        public ActionResult View1(String name)
        {
            // Modelの使用
            // ModelのコーディングはWebを意識する必要がない
            Models.CreateString cs = new Models.CreateString();

            // ViewData: ViewとControllerで値を受け渡したいときに使用する。使用方法はDictionaryと同様である。
            ViewData["msg"] = cs.Create(name, 1);
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult View2(string name)
        {
            Models.CreateString cs = new Models.CreateString();

            ViewData["msg"] = cs.Create(name, 2);
            //return View("View2");   // 引数にView名を指定することも可能である。
            return View();
        }
    }
}