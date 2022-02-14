using Microsoft.AspNetCore.Mvc;
using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocVienController
    {
        private readonly IHocVienService _HocVienService;
        public HocVienController(IHocVienService HocVienService)
        {
            _HocVienService = HocVienService;
        }
        [HttpGet]
        public IEnumerable<HocVienResponse> HocVienDanhSach(Guid? ID)
        {
            return _HocVienService.HocVienDanhSach(ID);
        }
        [HttpGet("{id}")]
        public HocVienResponse HocVienLayID(Guid ID)
        {
            return _HocVienService.HocVienLayID(ID);
        }
        [HttpPut]
        public int HocVienChinhSua([FromBody] HocVienRequest request)
        {
            return _HocVienService.HocVienChinhSua(request);
        }
        [HttpPost]
        public int HocVienTaoMoi([FromBody] HocVienRequest request)
        {
            return _HocVienService.HocVienTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool HocVienXoaBo(Guid ID)
        {
            return _HocVienService.HocVienXoaBo(ID);
        }

    }
}
