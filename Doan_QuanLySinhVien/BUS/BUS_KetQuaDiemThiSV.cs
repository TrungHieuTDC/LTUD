using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
   public class BUS_KetQuaDiemThiSV
    {
        DAL_KetQuaThiSV dal_ketQuaThiSV = new DAL_KetQuaThiSV();
        public int InsertValueDiemThi_SV(KetQuaThiSV kqDiemThi)
        {
            return dal_ketQuaThiSV.InsertValue_DiemThi(kqDiemThi.MaMH, kqDiemThi.MaSV, kqDiemThi.DiemThi);
        }
        public DataTable getDataDiemThi_SV(string maSV)
        {
            return dal_ketQuaThiSV.getKetQuaThi(maSV);
        }

        public int UpdateDiemThi_SV(KetQuaThiSV kq)
        {
            return dal_ketQuaThiSV.UpdateDiemThi_SV(kq.MaMH, kq.MaSV, kq.DiemThi);
        }
        public DataTable SearchDataMonHocSV(string maSV, string maMH)
        {
            return dal_ketQuaThiSV.SearchDataMonHoc(maSV, maMH);
        }
    }
}
