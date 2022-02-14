﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.BAL.Interface
{
    public interface ILoaiTuLieuService
    {
        List<LoaiTuLieuResponse> LoaiTuLieuDanhSach();
        LoaiTuLieuResponse LoaiTuLieuLayID(Guid ID);
        string LoaiTuLieuChinhSua(LoaiTuLieuRequest request);
        string LoaiTuLieuTaoMoi(LoaiTuLieuRequest request);
        bool LoaiTuLieuXoaBo(Guid ID);
    }
}
