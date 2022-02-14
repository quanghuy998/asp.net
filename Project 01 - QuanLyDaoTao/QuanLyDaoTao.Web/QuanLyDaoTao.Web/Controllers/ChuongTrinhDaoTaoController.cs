using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyDaoTao.Web.Models.ChuongTrinhDaoTao;
using QuanLyDaoTao.Web.Models.FileUpload;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace QuanLyDaoTao.Web.Controllers
{
    public class ChuongTrinhDaoTaoController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ChuongTrinhDaoTaoController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        // Danh sách chương trình đào tạo tìm kiếm theo trạng thái và mã chương trình    
        public JsonResult DanhSach(int TrangThai, string MaCT)
        {
            var danhsach = new List<DanhSach>();
            string url = $"{Common.Common.ApiUrl}/ChuongTrinhDaoTao?TrangThai={TrangThai}&MaCT={MaCT}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var httpWebResponse = httpWebRequest.GetResponse();
            {
                string streamData;
                Stream responseStream = httpWebResponse.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    {
                        try
                        {
                            streamData = streamReader.ReadToEnd();
                        }
                        finally
                        {
                            ((IDisposable)streamReader).Dispose();
                        }
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                danhsach = JsonConvert.DeserializeObject<List<DanhSach>>(streamData);
            }
            return Json(new { code = 200, msg = "Success", ctdt = danhsach });
        }
        // Tạo mới chương trình đào tạo
        [HttpPost]
        public JsonResult TaoMoi(TaoMoi model)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "files\\ChuongTrinhDaoTao");
            string filePath1 = Path.Combine(path, model.FileNoiDungCT.FileName);
            string filePath2 = Path.Combine(path, model.FileQDBanHanh.FileName);

            model.NoiDungCT = model.FileNoiDungCT.FileName;
            model.QDBanHanh = model.FileQDBanHanh.FileName;
            try
            {
                string url = $"{Common.Common.ApiUrl}/ChuongTrinhDaoTao";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var json = JsonConvert.SerializeObject(model);
                    streamWrite.Write(json);
                }
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (FileStream fileStream = new FileStream(path: filePath1, FileMode.Create))
                {
                    model.FileNoiDungCT.CopyTo(fileStream);
                }
                using (FileStream fileStream = new FileStream(path: filePath2, FileMode.Create))
                {
                    model.FileQDBanHanh.CopyTo(fileStream);
                }


                return Json(new { code = 200, msg = "Tạo mới thành công" });
            }
            catch (Exception ex) { return Json(new { code = 500, msg = "Tạo mới thất bại" + ex.Message }); }
        }

        // Chỉnh sửa chương trình đào tạo
        [HttpGet]
        public JsonResult LayTheoID(Guid ID)
        {
            var chuongTrinhDaoTao = new ChinhSua();
            string url = $"{Common.Common.ApiUrl}/ChuongTrinhDaoTao/{ID}";
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
                chuongTrinhDaoTao = JsonConvert.DeserializeObject<ChinhSua>(responseData);
            }
            return Json(new { code = 200, msg = "Lấy ID thành công", ctdt = chuongTrinhDaoTao});
        }

        [HttpPut]
        public IActionResult ChinhSua(ChinhSua model)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "files\\ChuongTrinhDaoTao");
            if(model.FileNoiDungCT != null)
            {
                string filePath1 = Path.Combine(path, model.FileNoiDungCT.FileName);
                model.NoiDungCT = model.FileNoiDungCT.FileName;
                using (FileStream fileStream = new FileStream(path: filePath1, FileMode.Create))
                {
                    model.FileNoiDungCT.CopyTo(fileStream);
                }
            }
            if(model.FileQDBanHanh != null)
            {
                string filePath2 = Path.Combine(path, model.FileQDBanHanh.FileName);
                model.QDBanHanh = model.FileQDBanHanh.FileName;
                using (FileStream fileStream = new FileStream(path: filePath2, FileMode.Create))
                {
                    model.FileQDBanHanh.CopyTo(fileStream);
                }
            }
            try
            {
                string url = $"{Common.Common.ApiUrl}/ChuongTrinhDaoTao/{model.ID}";
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
                return Json(new { code = 500, messenger = "Chỉnh sửa thất bại" + ex.Message });
            }
        }


        // Xóa bỏ chương trình đào tạo
        public JsonResult XoaBo(Guid ID)
        {
            try
            {
                bool ketqua = false;
                string url = $"{Common.Common.ApiUrl}/ChuongTrinhDaoTao/{ID}";
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
                return Json(new { code = 200, msg = "Xóa bỏ thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Xóa bỏ thất bại" + ex.Message });
            }
        }
    }
}
