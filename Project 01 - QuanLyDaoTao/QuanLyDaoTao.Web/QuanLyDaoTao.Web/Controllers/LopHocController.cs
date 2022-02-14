using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using QuanLyDaoTao.Web.Models.LopHoc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Controllers
{
    public class LopHocController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public LopHocController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public ActionResult Index()
        {
            return View();
        }
        //Danh sách lớp học
        public JsonResult DanhSach(Guid? ID, Guid? CTDaoTaoID)
        {
            var danhsach = new List<DanhSach>();
            string url = $"{Common.Common.ApiUrl}/LopHoc?ID={ID}&CTDaoTaoID={CTDaoTaoID}";
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
            return Json(new { code = 200, msg = "Success", lophoc = danhsach });
        }
        // Tạo mới
        [HttpPost]
        public JsonResult TaoMoi(TaoMoi model)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "files\\LopHoc");
            if (model.FileQDMoLop != null)
            {
                string filePath1 = Path.Combine(path, model.FileQDMoLop.FileName);
                model.QDMoLop = model.FileQDMoLop.FileName;
                using (FileStream fileStream = new FileStream(path: filePath1, FileMode.Create))
                {
                    model.FileQDMoLop.CopyTo(fileStream);
                }
            }
            if (model.FileThoiKhoaBieu != null)
            {
                string filePath2 = Path.Combine(path, model.FileThoiKhoaBieu.FileName);
                model.ThoiKhoaBieu = model.FileThoiKhoaBieu.FileName;
                using (FileStream fileStream = new FileStream(path: filePath2, FileMode.Create))
                {
                    model.FileThoiKhoaBieu.CopyTo(fileStream);
                }
            }

            //Call API
            try
            {
                string url = $"{Common.Common.ApiUrl}/LopHoc";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/json";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var json = JsonConvert.SerializeObject(model);
                    streamWriter.Write(json);
                }
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                // Save File in Wwwroot
                return Json(new { code = 200, msg = "Tạo mới thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Tạo mới thất bại: " + ex.Message });
            }
        }
        // Lấy thông tin theo ID
        [HttpGet]
        public JsonResult LopHocLayID(Guid ID)
        {
            var lophoc = new ChinhSua();
            string url = $"{Common.Common.ApiUrl}/LopHoc/{ID}";
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
                lophoc = JsonConvert.DeserializeObject<ChinhSua>(responseData);
            }
            return Json(new { code = 200, msg = "Success", lophoc = lophoc });
        }
        // Chỉnh sửa lớp học
        [HttpPut]
        public IActionResult LopHocChinhSua(ChinhSua model)
        {
            // Save File in Wwwroot
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "files\\LopHoc");
            if (model.FileQDMoLop != null)
            {
                string filePath1 = Path.Combine(path, model.FileQDMoLop.FileName);
                model.QDMoLop = model.FileQDMoLop.FileName;
                using (FileStream fileStream = new FileStream(path: filePath1, FileMode.Create))
                {
                    model.FileQDMoLop.CopyTo(fileStream);
                }
            }
            if (model.FileThoiKhoaBieu != null)
            {
                string filePath2 = Path.Combine(path, model.FileThoiKhoaBieu.FileName);
                model.ThoiKhoaBieu = model.FileThoiKhoaBieu.FileName;
                using (FileStream fileStream = new FileStream(path: filePath2, FileMode.Create))
                {
                    model.FileThoiKhoaBieu.CopyTo(fileStream);
                }
            }

            //Call API
            try
            {
                string url = $"{Common.Common.ApiUrl}/LopHoc/{model.ID}";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var json = JsonConvert.SerializeObject(model);
                    streamWrite.Write(json);
                }
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                return Json(new { code = 200, msg = "Chỉnh sửa thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, messenger = "Chỉnh sửa thất bại: " + ex.Message });
            }
        }
        // Xóa lớp học
        [HttpDelete]
        public JsonResult LopHocXoaBo(Guid ID)
        {
            try
            {
                bool ketqua = false;
                string url = $"{Common.Common.ApiUrl}/LopHoc/{ID}";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "DELETE";
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                {
                    string respsonseData;
                    Stream responseStream = httpWebResponse.GetResponseStream();
                    try
                    {
                        StreamReader streamReader = new StreamReader(responseStream);
                        try
                        {
                            respsonseData = streamReader.ReadToEnd();
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
                    ketqua = JsonConvert.DeserializeObject<bool>(respsonseData);
                }
                return Json(new { code = 200, msg = "Xóa lớp học thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Xóa lớp học thất bại: " + ex.Message });
            }
        }
    }
}
