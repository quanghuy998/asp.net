using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyDaoTao.Web.Models.FileUpload;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult LayTheoDoiTuongID(Guid DoiTuongID)
        {
            var fileUpload = new List<FileUpload>();
            string url = $"{Common.Common.ApiUrl}/FileUpload/{DoiTuongID}";
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
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                fileUpload = JsonConvert.DeserializeObject<List<FileUpload>>(responseData);
            }
            return Json(new { code = 200, msg = "Success", files = fileUpload });
        }
    }
}
