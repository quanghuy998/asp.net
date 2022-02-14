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
    public class ThongTinHDController
    {
        private readonly IThongTinHDService _ThongTinHDService;
        public ThongTinHDController(IThongTinHDService ThongTinHDService)
        {
            _ThongTinHDService = ThongTinHDService;
        }
        [HttpGet]
        public IEnumerable<ThongTinHDResponse> ThongTinHDDanhSach(Guid? ID)
        {
            return _ThongTinHDService.ThongTinHDDanhSach(ID);
        }
        [HttpGet("{id}")]
        public ThongTinHDResponse ThongTinHDLayID(Guid ID)
        {
            return _ThongTinHDService.ThongTinHDLayID(ID);
        }
        [HttpPut]
        public int ThongTinHDChinhSua([FromBody] ThongTinHDRequest request)
        {
            return _ThongTinHDService.ThongTinHDChinhSua(request);
        }
        [HttpPost]
        public int ThongTinHDTaoMoi([FromBody] ThongTinHDRequest request)
        {
            return _ThongTinHDService.ThongTinHDTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool ThongTinHDXoaBo(Guid ID)
        {
            return _ThongTinHDService.ThongTinHDXoaBo(ID);
        }

    }
}
