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
    public class ThoiKhoaBieuController
    {
        private readonly IThoiKhoaBieuService _ThoiKhoaBieuService;
        public ThoiKhoaBieuController(IThoiKhoaBieuService ThoiKhoaBieuService)
        {
            _ThoiKhoaBieuService = ThoiKhoaBieuService;
        }
        [HttpGet]
        public IEnumerable<ThoiKhoaBieuResponse> ThoiKhoaBieuDanhSach(Guid? ID)
        {
            return _ThoiKhoaBieuService.ThoiKhoaBieuDanhSach(ID);
        }
        [HttpGet("{id}")]
        public ThoiKhoaBieuResponse ThoiKhoaBieuLayID(Guid ID)
        {
            return _ThoiKhoaBieuService.ThoiKhoaBieuLayID(ID);
        }
        [HttpPut]
        public int ThoiKhoaBieuChinhSua([FromBody] ThoiKhoaBieuRequest request)
        {
            return _ThoiKhoaBieuService.ThoiKhoaBieuChinhSua(request);
        }
        [HttpPost]
        public int ThoiKhoaBieuTaoMoi([FromBody] ThoiKhoaBieuRequest request)
        {
            return _ThoiKhoaBieuService.ThoiKhoaBieuTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool ThoiKhoaBieuXoaBo(Guid ID)
        {
            return _ThoiKhoaBieuService.ThoiKhoaBieuXoaBo(ID);
        }

    }
}
