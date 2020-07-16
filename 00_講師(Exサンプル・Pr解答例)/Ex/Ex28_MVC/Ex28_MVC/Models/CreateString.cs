using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex28_MVC.Models
{
    public class CreateString
    {
        public string Create(string name, int pageNum)
        {
            if (pageNum == 1)
            {
                return String.Format("ようこそ、{0}さん！", name);
            }
            else
            {
                return String.Format("Welcome, {0}！", name);
            }
        }
    }
}