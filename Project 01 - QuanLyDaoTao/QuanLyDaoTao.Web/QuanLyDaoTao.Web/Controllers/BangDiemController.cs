using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyDaoTao.Web.Models.BangDiem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Controllers
{
    public class BangDiemController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BangDiemController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult DanhSach(Guid? CTDaoTaoID, Guid? LopHocID, Guid? HocVienID, Guid? MonHocID)
        {
            var danhsach = new List<DanhSach>();
            string url = $"{Common.Common.ApiUrl}/BangDiem?CTDaoTaoID={CTDaoTaoID}&LopHocID={LopHocID}&HocVienID={HocVienID}&MonHocID={MonHocID}";
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
            return Json(new { code = 200, msg = "Success", bangdiem = danhsach });
        }
    }
}
