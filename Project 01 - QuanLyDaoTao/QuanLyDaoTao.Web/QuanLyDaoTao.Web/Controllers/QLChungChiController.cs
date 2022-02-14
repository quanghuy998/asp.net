using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyDaoTao.Web.Models.QLChungChi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Controllers
{
    public class QLChungChiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult DanhSach(Guid? ID)
        {
            var danhsach = new List<DanhSach>();
            string url = $"{Common.Common.ApiUrl}/QLChungChi?ID={ID}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var httpWebResponse = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = httpWebResponse.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)responseStream).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                danhsach = JsonConvert.DeserializeObject<List<DanhSach>>(responseData);
            }
            return Json(new { code = 200, msg = "Success", qlchungchi = danhsach });
        }
    }
}
